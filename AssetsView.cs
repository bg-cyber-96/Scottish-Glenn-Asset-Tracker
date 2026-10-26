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

            Dock = DockStyle.Fill;

            LoadDashboardData();

            LoadHardwareDetails();

            LoadEmployeesIntoComboBox();
        }

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
            dtpPurchaseDate.Value = DateTime.Today;
            cmbAssignedEmployee.SelectedIndex = -1;
            txtNotes.Clear();

            LoadHardwareDetails();
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
    }
}
