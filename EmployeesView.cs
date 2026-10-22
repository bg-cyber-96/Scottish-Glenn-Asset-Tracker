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
    public partial class EmployeesView : UserControl
    {
        public EmployeesView()
        {
            InitializeComponent();

            LoadEmployeeSummary();
            LoadDepartments();
            LoadEmployees();

            Dock = DockStyle.Fill;
            BackColor = System.Drawing.Color.White;
            Font = new System.Drawing.Font("Segoe UI", 10F);
        }

        private void LoadEmployeeSummary()
        {
            try
            {
                AssetDataAccess dataAccess = new AssetDataAccess();

                // Display the total number of employees
                lblTotalEmployeeCount.Text =
                    dataAccess.GetEmployeeCount().ToString();

                // Display the number of departments
                lblTotalDepartmentsCount.Text = "5";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load employee summary. \n\n" + ex.Message,
                    "Employee Summary Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
            }
        }

        private void LoadEmployees()
        {
            try
            {
                AssetDataAccess dataAccess = new AssetDataAccess();

                dgvEmployees.DataSource = dataAccess.GetEmployees();

                if (dgvEmployees.Columns["EmployeeID"] != null)
                {
                    dgvEmployees.Columns["EmployeeID"].Visible = false;
                }

                if (dgvEmployees.Columns["DepartmentID"] != null)
                {
                    dgvEmployees.Columns["DepartmentID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load employee records. \n\n" + ex.Message,
                    "Employee Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
            }
        }

        private void LoadDepartments()
        {
            try
            {
                AssetDataAccess dataAccess = new AssetDataAccess();

                cmbDepartment.DataSource = dataAccess.GetDepartments();
                cmbDepartment.DisplayMember = "DepartmentName";
                cmbDepartment.ValueMember = "DepartmentID";
                cmbDepartment.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load departments.\n\n" + ex.Message,
                    "Department Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ClearEmployeeFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();

            cmbDepartment.SelectedIndex = -1;

            dgvEmployees.ClearSelection();
        }

        private void lblTotalDepartmentsTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select an employee from the table first.",
                    "No Employee Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) ||
                cmbDepartment.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please complete all fields and select a department.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show(
                    "Please enter a valid email address.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                int employeeID = Convert.ToInt32(
                    dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);

                Employee employee = new Employee
                {
                    EmployeeID = employeeID,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    DepartmentID = Convert.ToInt32(
                        cmbDepartment.SelectedValue)
                };

                AssetDataAccess dataAccess = new AssetDataAccess();

                int rowsAffected = dataAccess.UpdateEmployee(employee);

                if (rowsAffected > 0)
                {
                    LoadEmployees();
                    LoadEmployeeSummary();
                    ClearEmployeeFields();

                    MessageBox.Show(
                        "Employee updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "The employee record was not updated.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update employee.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) ||
                cmbDepartment.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please complete all fields and select a department!",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show(
                    "Please enter a valid email address.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                Employee employee = new Employee
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue)
                };

                AssetDataAccess dataAccess = new AssetDataAccess();

                dataAccess.AddEmployee(employee);

                LoadEmployees();
                LoadEmployeeSummary();
                ClearEmployeeFields();

                MessageBox.Show(
                    "Employee added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to add employee.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select an employee from the table first.",
                    "No Employee Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow selectedRow = dgvEmployees.SelectedRows[0];

            int employeeID = Convert.ToInt32(
                selectedRow.Cells["EmployeeID"].Value);

            string firstName =
                selectedRow.Cells["FirstName"].Value.ToString();

            string lastName =
                selectedRow.Cells["LastName"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {firstName} {lastName}?",
                "Confirm Employee Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                AssetDataAccess dataAccess = new AssetDataAccess();

                int rowsAffected = dataAccess.DeleteEmployee(employeeID);

                if (rowsAffected > 0)
                {
                    LoadEmployees();
                    LoadEmployeeSummary();
                    ClearEmployeeFields();

                    MessageBox.Show(
                        "Employee deleted successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "The employee record was not deleted.",
                        "Delete Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to delete employee. They may still have assets assigned to them.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClearEmployee_Click(object sender, EventArgs e)
        {
            ClearEmployeeFields();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];

            txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
            txtLastName.Text = row.Cells["LastName"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();

            cmbDepartment.SelectedValue =
                Convert.ToInt32(row.Cells["DepartmentID"].Value);
        }
    }
}
