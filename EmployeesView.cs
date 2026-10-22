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
            LoadEmployes();

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

        private void LoadEmployes()
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

        private void button2_Click(object sender, EventArgs e)
        {

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

                LoadEmployes();
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

        }

        private void btnClearEmployee_Click(object sender, EventArgs e)
        {
            ClearEmployeeFields();
        }
    }
}
