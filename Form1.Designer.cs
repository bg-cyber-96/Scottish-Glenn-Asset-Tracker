namespace Scottish_Glen_Asset_Tracking
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnAssets = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.lblDashboardDescription = new System.Windows.Forms.Label();
            this.pnlTotalAssets = new System.Windows.Forms.Panel();
            this.lblTotalAssetsTitle = new System.Windows.Forms.Label();
            this.lblTotalAssetsCount = new System.Windows.Forms.Label();
            this.pnlTotalEmployees = new System.Windows.Forms.Panel();
            this.lblTotalEmployeesTitle = new System.Windows.Forms.Label();
            this.lblTotalEmployeesCount = new System.Windows.Forms.Label();
            this.dgvAssets = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlTotalAssets.SuspendLayout();
            this.pnlTotalEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.pnlHeader.Controls.Add(this.lblTitle2);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 90);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(34, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ScottishGlen";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(38, 55);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(177, 23);
            this.lblTitle2.TabIndex = 1;
            this.lblTitle2.Text = "Asset Tracking System";
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.pnlNavigation.Controls.Add(this.btnDepartments);
            this.pnlNavigation.Controls.Add(this.btnEmployees);
            this.pnlNavigation.Controls.Add(this.btnAssets);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 90);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(200, 360);
            this.pnlNavigation.TabIndex = 1;
            // 
            // btnAssets
            // 
            this.btnAssets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.btnAssets.FlatAppearance.BorderSize = 0;
            this.btnAssets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssets.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssets.ForeColor = System.Drawing.Color.White;
            this.btnAssets.Location = new System.Drawing.Point(12, 65);
            this.btnAssets.Name = "btnAssets";
            this.btnAssets.Size = new System.Drawing.Size(170, 45);
            this.btnAssets.TabIndex = 0;
            this.btnAssets.Text = "Assets";
            this.btnAssets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssets.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.btnEmployees.Location = new System.Drawing.Point(12, 135);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(170, 45);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.UseVisualStyleBackColor = false;
            // 
            // btnDepartments
            // 
            this.btnDepartments.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDepartments.FlatAppearance.BorderSize = 0;
            this.btnDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartments.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.btnDepartments.Location = new System.Drawing.Point(12, 205);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(170, 45);
            this.btnDepartments.TabIndex = 2;
            this.btnDepartments.Text = "Departments";
            this.btnDepartments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartments.UseVisualStyleBackColor = false;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.White;
            this.pnlMainContent.Controls.Add(this.dgvAssets);
            this.pnlMainContent.Controls.Add(this.pnlTotalEmployees);
            this.pnlMainContent.Controls.Add(this.pnlTotalAssets);
            this.pnlMainContent.Controls.Add(this.lblDashboardDescription);
            this.pnlMainContent.Controls.Add(this.lblDashboardTitle);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(200, 90);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMainContent.Size = new System.Drawing.Size(600, 360);
            this.pnlMainContent.TabIndex = 2;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.lblDashboardTitle.Location = new System.Drawing.Point(20, 20);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(171, 41);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Dashboard";
            // 
            // lblDashboardDescription
            // 
            this.lblDashboardDescription.AutoSize = true;
            this.lblDashboardDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDashboardDescription.Location = new System.Drawing.Point(20, 65);
            this.lblDashboardDescription.Name = "lblDashboardDescription";
            this.lblDashboardDescription.Size = new System.Drawing.Size(272, 23);
            this.lblDashboardDescription.TabIndex = 1;
            this.lblDashboardDescription.Text = "Manage your organisation\'s assets";
            // 
            // pnlTotalAssets
            // 
            this.pnlTotalAssets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalAssets.Controls.Add(this.lblTotalAssetsCount);
            this.pnlTotalAssets.Controls.Add(this.lblTotalAssetsTitle);
            this.pnlTotalAssets.Location = new System.Drawing.Point(20, 110);
            this.pnlTotalAssets.Name = "pnlTotalAssets";
            this.pnlTotalAssets.Size = new System.Drawing.Size(250, 100);
            this.pnlTotalAssets.TabIndex = 2;
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
            this.lblTotalAssetsTitle.Click += new System.EventHandler(this.lblTotalAssetsTitle_Click);
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
            // pnlTotalEmployees
            // 
            this.pnlTotalEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalEmployees.Controls.Add(this.lblTotalEmployeesCount);
            this.pnlTotalEmployees.Controls.Add(this.lblTotalEmployeesTitle);
            this.pnlTotalEmployees.Location = new System.Drawing.Point(290, 110);
            this.pnlTotalEmployees.Name = "pnlTotalEmployees";
            this.pnlTotalEmployees.Size = new System.Drawing.Size(250, 100);
            this.pnlTotalEmployees.TabIndex = 3;
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
            this.lblTotalEmployeesTitle.Click += new System.EventHandler(this.lblTotalEmployeesTitle_Click);
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
            this.dgvAssets.Location = new System.Drawing.Point(20, 228);
            this.dgvAssets.MultiSelect = false;
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.ReadOnly = true;
            this.dgvAssets.RowHeadersVisible = false;
            this.dgvAssets.RowHeadersWidth = 51;
            this.dgvAssets.RowTemplate.Height = 24;
            this.dgvAssets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssets.Size = new System.Drawing.Size(520, 120);
            this.dgvAssets.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            this.pnlTotalAssets.ResumeLayout(false);
            this.pnlTotalAssets.PerformLayout();
            this.pnlTotalEmployees.ResumeLayout(false);
            this.pnlTotalEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnAssets;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Panel pnlTotalAssets;
        private System.Windows.Forms.Label lblDashboardDescription;
        private System.Windows.Forms.Label lblTotalAssetsCount;
        private System.Windows.Forms.Label lblTotalAssetsTitle;
        private System.Windows.Forms.Panel pnlTotalEmployees;
        private System.Windows.Forms.Label lblTotalEmployeesTitle;
        private System.Windows.Forms.Label lblTotalEmployeesCount;
        private System.Windows.Forms.DataGridView dgvAssets;
    }
}

