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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                AssetDataAccess dataAccess = new AssetDataAccess();

                // Update the summary cards
                lblTotalAssetsCount.Text =
                    dataAccess.GetAssetCount().ToString();

                lblTotalEmployeesCount.Text =
                    dataAccess.GetEmployeeCount().ToString();

                // Load the asset records into the table
                dgvAssets.DataSource = dataAccess.GetAssets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unalbe to load dashboard data. \n\n" + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalAssetsTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalEmployeesTitle_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
