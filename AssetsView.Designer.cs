namespace Scottish_Glen_Asset_Tracking
{
    partial class AssetsView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDashboardDescription = new System.Windows.Forms.Label();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.lblTotalAssetsCount = new System.Windows.Forms.Label();
            this.lblTotalAssetsTitle = new System.Windows.Forms.Label();
            this.lblTotalEmployeesCount = new System.Windows.Forms.Label();
            this.lblTotalEmployeesTitle = new System.Windows.Forms.Label();
            this.dgvAssets = new System.Windows.Forms.DataGridView();
            this.pnlTotalEmployees = new System.Windows.Forms.Panel();
            this.pnlTotalAssets = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.pnlTotalEmployees.SuspendLayout();
            this.pnlTotalAssets.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDashboardDescription
            // 
            this.lblDashboardDescription.AutoSize = true;
            this.lblDashboardDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDashboardDescription.Location = new System.Drawing.Point(25, 117);
            this.lblDashboardDescription.Name = "lblDashboardDescription";
            this.lblDashboardDescription.Size = new System.Drawing.Size(272, 23);
            this.lblDashboardDescription.TabIndex = 6;
            this.lblDashboardDescription.Text = "Manage your organisation\'s assets";
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.lblDashboardTitle.Location = new System.Drawing.Point(25, 72);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(171, 41);
            this.lblDashboardTitle.TabIndex = 5;
            this.lblDashboardTitle.Text = "Dashboard";
            // 
            // lblTotalAssetsCount
            // 
            this.lblTotalAssetsCount.AutoSize = true;
            this.lblTotalAssetsCount.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAssetsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.lblTotalAssetsCount.Location = new System.Drawing.Point(3, 47);
            this.lblTotalAssetsCount.Name = "lblTotalAssetsCount";
            this.lblTotalAssetsCount.Size = new System.Drawing.Size(43, 50);
            this.lblTotalAssetsCount.TabIndex = 1;
            this.lblTotalAssetsCount.Text = "0";
            // 
            // lblTotalAssetsTitle
            // 
            this.lblTotalAssetsTitle.AutoSize = true;
            this.lblTotalAssetsTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAssetsTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalAssetsTitle.Location = new System.Drawing.Point(3, 24);
            this.lblTotalAssetsTitle.Name = "lblTotalAssetsTitle";
            this.lblTotalAssetsTitle.Size = new System.Drawing.Size(98, 23);
            this.lblTotalAssetsTitle.TabIndex = 0;
            this.lblTotalAssetsTitle.Text = "Total Assets";
            // 
            // lblTotalEmployeesCount
            // 
            this.lblTotalEmployeesCount.AutoSize = true;
            this.lblTotalEmployeesCount.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployeesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.lblTotalEmployeesCount.Location = new System.Drawing.Point(14, 47);
            this.lblTotalEmployeesCount.Name = "lblTotalEmployeesCount";
            this.lblTotalEmployeesCount.Size = new System.Drawing.Size(43, 50);
            this.lblTotalEmployeesCount.TabIndex = 1;
            this.lblTotalEmployeesCount.Text = "0";
            // 
            // lblTotalEmployeesTitle
            // 
            this.lblTotalEmployeesTitle.AutoSize = true;
            this.lblTotalEmployeesTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployeesTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalEmployeesTitle.Location = new System.Drawing.Point(10, 24);
            this.lblTotalEmployeesTitle.Name = "lblTotalEmployeesTitle";
            this.lblTotalEmployeesTitle.Size = new System.Drawing.Size(91, 23);
            this.lblTotalEmployeesTitle.TabIndex = 0;
            this.lblTotalEmployeesTitle.Text = "Employees";
            // 
            // dgvAssets
            // 
            this.dgvAssets.AllowUserToAddRows = false;
            this.dgvAssets.AllowUserToDeleteRows = false;
            this.dgvAssets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAssets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssets.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssets.Location = new System.Drawing.Point(35, 314);
            this.dgvAssets.MultiSelect = false;
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.ReadOnly = true;
            this.dgvAssets.RowHeadersVisible = false;
            this.dgvAssets.RowHeadersWidth = 51;
            this.dgvAssets.RowTemplate.Height = 24;
            this.dgvAssets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssets.Size = new System.Drawing.Size(1057, 363);
            this.dgvAssets.TabIndex = 9;
            // 
            // pnlTotalEmployees
            // 
            this.pnlTotalEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalEmployees.Controls.Add(this.lblTotalEmployeesCount);
            this.pnlTotalEmployees.Controls.Add(this.lblTotalEmployeesTitle);
            this.pnlTotalEmployees.Location = new System.Drawing.Point(355, 178);
            this.pnlTotalEmployees.Name = "pnlTotalEmployees";
            this.pnlTotalEmployees.Size = new System.Drawing.Size(250, 100);
            this.pnlTotalEmployees.TabIndex = 8;
            // 
            // pnlTotalAssets
            // 
            this.pnlTotalAssets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalAssets.Controls.Add(this.lblTotalAssetsCount);
            this.pnlTotalAssets.Controls.Add(this.lblTotalAssetsTitle);
            this.pnlTotalAssets.Location = new System.Drawing.Point(32, 178);
            this.pnlTotalAssets.Name = "pnlTotalAssets";
            this.pnlTotalAssets.Size = new System.Drawing.Size(250, 100);
            this.pnlTotalAssets.TabIndex = 7;
            // 
            // AssetsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDashboardDescription);
            this.Controls.Add(this.lblDashboardTitle);
            this.Controls.Add(this.dgvAssets);
            this.Controls.Add(this.pnlTotalEmployees);
            this.Controls.Add(this.pnlTotalAssets);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AssetsView";
            this.Size = new System.Drawing.Size(1109, 735);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).EndInit();
            this.pnlTotalEmployees.ResumeLayout(false);
            this.pnlTotalEmployees.PerformLayout();
            this.pnlTotalAssets.ResumeLayout(false);
            this.pnlTotalAssets.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashboardDescription;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Label lblTotalAssetsCount;
        private System.Windows.Forms.Label lblTotalAssetsTitle;
        private System.Windows.Forms.Label lblTotalEmployeesCount;
        private System.Windows.Forms.Label lblTotalEmployeesTitle;
        private System.Windows.Forms.DataGridView dgvAssets;
        private System.Windows.Forms.Panel pnlTotalEmployees;
        private System.Windows.Forms.Panel pnlTotalAssets;
    }
}
