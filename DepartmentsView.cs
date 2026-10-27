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
    public partial class DepartmentsView : UserControl
    {
        public DepartmentsView()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            LoadDepartments();
        }

        private void LoadDepartments()
        {
            try
            {
                AssetDataAccess dataAccess =
                    new AssetDataAccess();

                dgvDepartments.DataSource =
                    dataAccess.GetDepartments();

                dgvDepartments.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvDepartments.ReadOnly = true;
                dgvDepartments.AllowUserToAddRows = false;
                dgvDepartments.AllowUserToDeleteRows = false;
                dgvDepartments.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvDepartments.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load departments.\n\n" + ex.Message,
                    "Departments Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
    
