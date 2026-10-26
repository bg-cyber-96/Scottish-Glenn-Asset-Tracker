using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scottish_Glen_Asset_Tracking
{
    public partial class AssetsView : UserControl
    {
        public AssetsView()
        {
            InitializeComponent();

            btnUpdateAsset.Enabled = false;
            btnDeleteAsset.Enabled = false;

            Dock = DockStyle.Fill;

            LoadDashboardData();

            LoadHardwareDetails();

            LoadEmployeesIntoComboBox();
        }

        private int selectedAssetID = 0;

        private void LoadDashboardData()
        {
            try
            {
                AssetDataAccess dataAccess = new AssetDataAccess();

                lblTotalAssetsCount.Text =
                    dataAccess.GetAssetCount().ToString();

                lblTotalEmployeesCount.Text =
                    dataAccess.GetEmployeeCount().ToString();

                dgvAssets.DataSource = dataAccess.GetAssets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load dashboard data.\n\n" + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadHardwareDetails()
        {
            try
            {
                HardwareInfoProvider hardware = new HardwareInfoProvider();

                txtSystemName.Text = hardware.GetSystemName();
                txtManufacturer.Text = hardware.GetManufacturer();
                txtModel.Text = hardware.GetModel();
                txtHardwareType.Text = hardware.GetHardwareType();
                txtIPAddress.Text = hardware.GetIPAddress();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to detect hardware details.\n\n" + ex.Message,
                    "Hardware Detection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void LoadEmployeesIntoComboBox()
        {
            try
            {
                AssetDataAccess dataAccess = new AssetDataAccess();

                DataTable employees = dataAccess.GetEmployees();

                // Dropdown
                if (!employees.Columns.Contains("DisplayName"))
                {
                    employees.Columns.Add("DisplayName", typeof(string));

                    foreach (DataRow row in employees.Rows)
                    {
                        row["DisplayName"] =
                            row["FirstName"].ToString() + " " +
                            row["LastName"].ToString();
                    }
                }

                cmbAssignedEmployee.DataSource = employees;
                cmbAssignedEmployee.DisplayMember = "DisplayName";
                cmbAssignedEmployee.ValueMember = "EmployeeID";
                cmbAssignedEmployee.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load employees.\n\n" + ex.Message,
                    "Employee Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ClearAssetsForm()
        {
            selectedAssetID = 0;

            dtpPurchaseDate.Value = DateTime.Today;
            cmbAssignedEmployee.SelectedIndex = -1;
            txtNotes.Clear();

            LoadHardwareDetails();

            btnUpdateAsset.Enabled = false;
            btnDeleteAsset.Enabled = false;
        }

        private void btnRefreshHardware_Click(object sender, EventArgs e)
        {
            LoadHardwareDetails();
        }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSystemName.Text) ||
                string.IsNullOrWhiteSpace(txtManufacturer.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtHardwareType.Text) ||
                string.IsNullOrWhiteSpace(txtIPAddress.Text))
            {
                MessageBox.Show(
                    "Hardware details could not be detected. " +
                    "Please refresh the hardware details and try again.",
                    "Missing Hardware Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbAssignedEmployee.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select an employee for this asset.",
                    "Employee Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Asset asset = new Asset
            {
                SystemName = txtSystemName.Text.Trim(),
                Manufacturer = txtManufacturer.Text.Trim(),
                Model = txtModel.Text.Trim(),
                AssetType = txtHardwareType.Text.Trim(),
                IPAddress = txtIPAddress.Text.Trim(),
                PurchaseDate = dtpPurchaseDate.Value.Date,
                EmployeeID = Convert.ToInt32(
                    cmbAssignedEmployee.SelectedValue),
                Notes = string.IsNullOrWhiteSpace(txtNotes.Text)
                    ? null
                    : txtNotes.Text.Trim()
            };

            try
            {
                AssetDataAccess dataAccess = new AssetDataAccess();

                int newAssetID = dataAccess.AddAsset(asset);

                LoadDashboardData();

                MessageBox.Show(
                    "Asset added successfully!",
                    "Asset Saved!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearAssetsForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to add the asset.\n\n" + ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvAssets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on the column headers.
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvAssets.Rows[e.RowIndex];

            selectedAssetID = Convert.ToInt32(
                row.Cells["AssetID"].Value );

            txtSystemName.Text =
                row.Cells["SystemName"].Value?.ToString() ?? "";

            txtManufacturer.Text =
                row.Cells["Manufacturer"].Value?.ToString() ?? "";

            txtModel.Text =
                row.Cells["Model"].Value?.ToString() ?? "";

            txtHardwareType.Text =
                row.Cells["AssetType"].Value?.ToString() ?? "";

            txtIPAddress.Text =
                row.Cells["IPAddress"].Value?.ToString() ?? "";

            txtNotes.Text =
                row.Cells["Notes"].Value?.ToString() ?? "";

            // Load the purchase date.
            if (row.Cells["PurchaseDate"].Value != null &&
                DateTime.TryParse(
                    row.Cells["PurchaseDate"].Value.ToString(),
                    out DateTime purchaseDate))
            {
                dtpPurchaseDate.Value = purchaseDate;
            }

            // Select the employee assigned to this asset.
            if (row.Cells["EmployeeID"].Value != null)
            {
                cmbAssignedEmployee.SelectedValue =
                    Convert.ToInt32(row.Cells["EmployeeID"].Value);
            }

            // Enable editing for the selected asset.
            btnUpdateAsset.Enabled = true;
            btnDeleteAsset.Enabled = true;
        }

        private void btnUpdateAsset_Click(object sender, EventArgs e)
        {
            if (selectedAssetID == 0)
            {
                MessageBox.Show(
                    "Please select an asset to update.",
                    "No Asset Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtSystemName.Text) ||
                string.IsNullOrWhiteSpace(txtManufacturer.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtHardwareType.Text) ||
                string.IsNullOrWhiteSpace(txtIPAddress.Text))
            {
                MessageBox.Show(
                    "Some hardware details are missing. " +
                    "Please refresh the hardware details before updating.",
                    "Missing Hardware Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbAssignedEmployee.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select an employee for this asset.",
                    "Employee Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Asset asset = new Asset
            {
                AssetID = selectedAssetID,
                SystemName = txtSystemName.Text.Trim(),
                Manufacturer = txtManufacturer.Text.Trim(),
                Model = txtModel.Text.Trim(),
                AssetType = txtHardwareType.Text.Trim(),
                IPAddress = txtIPAddress.Text.Trim(),
                PurchaseDate = dtpPurchaseDate.Value.Date,
                EmployeeID = Convert.ToInt32(
                    cmbAssignedEmployee.SelectedValue),
                Notes = string.IsNullOrWhiteSpace(txtNotes.Text)
                    ? null
                    : txtNotes.Text.Trim()
            };

            try
            {
                AssetDataAccess dataAccess = new AssetDataAccess();
                dataAccess.UpdateAsset(asset);

                LoadDashboardData();

                MessageBox.Show(
                    "Asset updated successfully.",
                    "Asset Updated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                selectedAssetID = 0;
                ClearAssetsForm();

                btnUpdateAsset.Enabled = false;
                btnDeleteAsset.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update the asset.\n\n" + ex.Message,
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAsset_Click(object sender, EventArgs e)
        {
            if (selectedAssetID == 0)
            {
                MessageBox.Show(
                    "Please select an asset to delete.",
                    "No Asset Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete Asset ID " +
                selectedAssetID + "?\n\nThis action cannot be undone.",
                "Confirm Asset Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                AssetDataAccess dataAccess = new AssetDataAccess();
                dataAccess.DeleteAsset(selectedAssetID);

                LoadDashboardData();

                MessageBox.Show(
                    "Asset deleted successfully.",
                    "Asset Deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                selectedAssetID = 0;
                ClearAssetsForm();

                btnUpdateAsset.Enabled = false;
                btnDeleteAsset.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to delete the asset.\n\n" + ex.Message,
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClearAsset_Click(object sender, EventArgs e)
        {
            ClearAssetsForm();
        }
    }
}
