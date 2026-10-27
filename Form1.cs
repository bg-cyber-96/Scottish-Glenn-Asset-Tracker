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

            AssetsView assetsView = new AssetsView();

            ShowView(new AssetsView());

            assetsView.Dock = DockStyle.Fill;
        }

        private void ShowView(UserControl view)
        {
            pnlMainContent.Controls.Clear();
            view.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(view);
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

        private void btnAssets_Click(object sender, EventArgs e)
        {
            ShowView(new AssetsView());
        }

        private void btnEmployees_click(object sender, EventArgs e)
        {
            ShowView(new EmployeesView());
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            ShowView(new DepartmentsView());
        }
    }
  
}
