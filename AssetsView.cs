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
    }
}
