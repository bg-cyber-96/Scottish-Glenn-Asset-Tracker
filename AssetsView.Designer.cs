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
            this.grpDetectedHardware = new System.Windows.Forms.GroupBox();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblHardwareType = new System.Windows.Forms.Label();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.txtSystemName = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtHardwareType = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.btnRefreshHardware = new System.Windows.Forms.Button();
            this.grpAssetDetails = new System.Windows.Forms.GroupBox();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.cmbAssignedEmployee = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnAddAsset = new System.Windows.Forms.Button();
            this.btnUpdateAsset = new System.Windows.Forms.Button();
            this.btnDeleteAsset = new System.Windows.Forms.Button();
            this.btnClearAsset = new System.Windows.Forms.Button();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblAssignedEmployee = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.pnlTotalEmployees.SuspendLayout();
            this.pnlTotalAssets.SuspendLayout();
            this.grpDetectedHardware.SuspendLayout();
            this.grpAssetDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDashboardDescription
            // 
            this.lblDashboardDescription.AutoSize = true;
            this.lblDashboardDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDashboardDescription.Location = new System.Drawing.Point(25, 62);
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
            this.lblDashboardTitle.Location = new System.Drawing.Point(25, 17);
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
            this.dgvAssets.Location = new System.Drawing.Point(35, 552);
            this.dgvAssets.MultiSelect = false;
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.ReadOnly = true;
            this.dgvAssets.RowHeadersVisible = false;
            this.dgvAssets.RowHeadersWidth = 51;
            this.dgvAssets.RowTemplate.Height = 24;
            this.dgvAssets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssets.Size = new System.Drawing.Size(1057, 100);
            this.dgvAssets.TabIndex = 9;
            this.dgvAssets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssets_CellClick);
            // 
            // pnlTotalEmployees
            // 
            this.pnlTotalEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalEmployees.Controls.Add(this.lblTotalEmployeesCount);
            this.pnlTotalEmployees.Controls.Add(this.lblTotalEmployeesTitle);
            this.pnlTotalEmployees.Location = new System.Drawing.Point(336, 103);
            this.pnlTotalEmployees.Name = "pnlTotalEmployees";
            this.pnlTotalEmployees.Size = new System.Drawing.Size(250, 100);
            this.pnlTotalEmployees.TabIndex = 8;
            // 
            // pnlTotalAssets
            // 
            this.pnlTotalAssets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalAssets.Controls.Add(this.lblTotalAssetsCount);
            this.pnlTotalAssets.Controls.Add(this.lblTotalAssetsTitle);
            this.pnlTotalAssets.Location = new System.Drawing.Point(35, 103);
            this.pnlTotalAssets.Name = "pnlTotalAssets";
            this.pnlTotalAssets.Size = new System.Drawing.Size(250, 100);
            this.pnlTotalAssets.TabIndex = 7;
            // 
            // grpDetectedHardware
            // 
            this.grpDetectedHardware.Controls.Add(this.btnRefreshHardware);
            this.grpDetectedHardware.Controls.Add(this.txtIPAddress);
            this.grpDetectedHardware.Controls.Add(this.txtModel);
            this.grpDetectedHardware.Controls.Add(this.txtHardwareType);
            this.grpDetectedHardware.Controls.Add(this.txtManufacturer);
            this.grpDetectedHardware.Controls.Add(this.txtSystemName);
            this.grpDetectedHardware.Controls.Add(this.lblIpAddress);
            this.grpDetectedHardware.Controls.Add(this.lblHardwareType);
            this.grpDetectedHardware.Controls.Add(this.lblModel);
            this.grpDetectedHardware.Controls.Add(this.lblManufacturer);
            this.grpDetectedHardware.Controls.Add(this.lblSystemName);
            this.grpDetectedHardware.Location = new System.Drawing.Point(614, 91);
            this.grpDetectedHardware.Name = "grpDetectedHardware";
            this.grpDetectedHardware.Size = new System.Drawing.Size(358, 303);
            this.grpDetectedHardware.TabIndex = 10;
            this.grpDetectedHardware.TabStop = false;
            this.grpDetectedHardware.Text = "Detected Hardware";
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Location = new System.Drawing.Point(9, 40);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(115, 23);
            this.lblSystemName.TabIndex = 0;
            this.lblSystemName.Text = "System Name";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(172, 40);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(113, 23);
            this.lblManufacturer.TabIndex = 1;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(9, 111);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(58, 23);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // lblHardwareType
            // 
            this.lblHardwareType.AutoSize = true;
            this.lblHardwareType.Location = new System.Drawing.Point(9, 183);
            this.lblHardwareType.Name = "lblHardwareType";
            this.lblHardwareType.Size = new System.Drawing.Size(123, 23);
            this.lblHardwareType.TabIndex = 3;
            this.lblHardwareType.Text = "Hardware Type";
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(172, 111);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(90, 23);
            this.lblIpAddress.TabIndex = 4;
            this.lblIpAddress.Text = "IP Address";
            // 
            // txtSystemName
            // 
            this.txtSystemName.Location = new System.Drawing.Point(13, 66);
            this.txtSystemName.Name = "txtSystemName";
            this.txtSystemName.ReadOnly = true;
            this.txtSystemName.Size = new System.Drawing.Size(136, 30);
            this.txtSystemName.TabIndex = 5;
            this.txtSystemName.TabStop = false;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(176, 66);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.ReadOnly = true;
            this.txtManufacturer.Size = new System.Drawing.Size(134, 30);
            this.txtManufacturer.TabIndex = 6;
            this.txtManufacturer.TabStop = false;
            // 
            // txtHardwareType
            // 
            this.txtHardwareType.Location = new System.Drawing.Point(13, 209);
            this.txtHardwareType.Name = "txtHardwareType";
            this.txtHardwareType.ReadOnly = true;
            this.txtHardwareType.Size = new System.Drawing.Size(135, 30);
            this.txtHardwareType.TabIndex = 7;
            this.txtHardwareType.TabStop = false;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(13, 137);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(136, 30);
            this.txtModel.TabIndex = 8;
            this.txtModel.TabStop = false;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(176, 137);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.ReadOnly = true;
            this.txtIPAddress.Size = new System.Drawing.Size(134, 30);
            this.txtIPAddress.TabIndex = 9;
            this.txtIPAddress.TabStop = false;
            // 
            // btnRefreshHardware
            // 
            this.btnRefreshHardware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.btnRefreshHardware.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshHardware.ForeColor = System.Drawing.Color.White;
            this.btnRefreshHardware.Location = new System.Drawing.Point(215, 209);
            this.btnRefreshHardware.Name = "btnRefreshHardware";
            this.btnRefreshHardware.Size = new System.Drawing.Size(95, 40);
            this.btnRefreshHardware.TabIndex = 10;
            this.btnRefreshHardware.Text = "Refresh";
            this.btnRefreshHardware.UseVisualStyleBackColor = false;
            this.btnRefreshHardware.Click += new System.EventHandler(this.btnRefreshHardware_Click);
            // 
            // grpAssetDetails
            // 
            this.grpAssetDetails.Controls.Add(this.lblNotes);
            this.grpAssetDetails.Controls.Add(this.lblAssignedEmployee);
            this.grpAssetDetails.Controls.Add(this.lblPurchaseDate);
            this.grpAssetDetails.Controls.Add(this.btnClearAsset);
            this.grpAssetDetails.Controls.Add(this.dtpPurchaseDate);
            this.grpAssetDetails.Controls.Add(this.btnDeleteAsset);
            this.grpAssetDetails.Controls.Add(this.cmbAssignedEmployee);
            this.grpAssetDetails.Controls.Add(this.btnUpdateAsset);
            this.grpAssetDetails.Controls.Add(this.txtNotes);
            this.grpAssetDetails.Controls.Add(this.btnAddAsset);
            this.grpAssetDetails.Location = new System.Drawing.Point(35, 228);
            this.grpAssetDetails.Name = "grpAssetDetails";
            this.grpAssetDetails.Size = new System.Drawing.Size(551, 309);
            this.grpAssetDetails.TabIndex = 11;
            this.grpAssetDetails.TabStop = false;
            this.grpAssetDetails.Text = "Asset Details";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(13, 82);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(197, 27);
            this.dtpPurchaseDate.TabIndex = 12;
            // 
            // cmbAssignedEmployee
            // 
            this.cmbAssignedEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignedEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssignedEmployee.FormattingEnabled = true;
            this.cmbAssignedEmployee.Location = new System.Drawing.Point(255, 82);
            this.cmbAssignedEmployee.Name = "cmbAssignedEmployee";
            this.cmbAssignedEmployee.Size = new System.Drawing.Size(236, 28);
            this.cmbAssignedEmployee.TabIndex = 13;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(13, 152);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(346, 151);
            this.txtNotes.TabIndex = 14;
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.btnAddAsset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAsset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAsset.ForeColor = System.Drawing.Color.White;
            this.btnAddAsset.Location = new System.Drawing.Point(387, 135);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(104, 31);
            this.btnAddAsset.TabIndex = 15;
            this.btnAddAsset.Text = "Add Asset";
            this.btnAddAsset.UseVisualStyleBackColor = false;
            this.btnAddAsset.Click += new System.EventHandler(this.btnAddAsset_Click);
            // 
            // btnUpdateAsset
            // 
            this.btnUpdateAsset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAsset.Location = new System.Drawing.Point(387, 180);
            this.btnUpdateAsset.Name = "btnUpdateAsset";
            this.btnUpdateAsset.Size = new System.Drawing.Size(104, 31);
            this.btnUpdateAsset.TabIndex = 16;
            this.btnUpdateAsset.Text = "Update";
            this.btnUpdateAsset.UseVisualStyleBackColor = true;
            this.btnUpdateAsset.Click += new System.EventHandler(this.btnUpdateAsset_Click);
            // 
            // btnDeleteAsset
            // 
            this.btnDeleteAsset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAsset.Location = new System.Drawing.Point(387, 225);
            this.btnDeleteAsset.Name = "btnDeleteAsset";
            this.btnDeleteAsset.Size = new System.Drawing.Size(104, 31);
            this.btnDeleteAsset.TabIndex = 17;
            this.btnDeleteAsset.Text = "Delete";
            this.btnDeleteAsset.UseVisualStyleBackColor = true;
            this.btnDeleteAsset.Click += new System.EventHandler(this.btnDeleteAsset_Click);
            // 
            // btnClearAsset
            // 
            this.btnClearAsset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAsset.Location = new System.Drawing.Point(387, 270);
            this.btnClearAsset.Name = "btnClearAsset";
            this.btnClearAsset.Size = new System.Drawing.Size(104, 31);
            this.btnClearAsset.TabIndex = 18;
            this.btnClearAsset.Text = "Clear";
            this.btnClearAsset.UseVisualStyleBackColor = true;
            this.btnClearAsset.Click += new System.EventHandler(this.btnClearAsset_Click);
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblPurchaseDate.Location = new System.Drawing.Point(9, 55);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(98, 20);
            this.lblPurchaseDate.TabIndex = 19;
            this.lblPurchaseDate.Text = "Select a date:";
            // 
            // lblAssignedEmployee
            // 
            this.lblAssignedEmployee.AutoSize = true;
            this.lblAssignedEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedEmployee.ForeColor = System.Drawing.Color.DimGray;
            this.lblAssignedEmployee.Location = new System.Drawing.Point(251, 55);
            this.lblAssignedEmployee.Name = "lblAssignedEmployee";
            this.lblAssignedEmployee.Size = new System.Drawing.Size(142, 20);
            this.lblAssignedEmployee.TabIndex = 20;
            this.lblAssignedEmployee.Text = "Select an employee:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.DimGray;
            this.lblNotes.Location = new System.Drawing.Point(9, 126);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(51, 20);
            this.lblNotes.TabIndex = 21;
            this.lblNotes.Text = "Notes:";
            // 
            // AssetsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grpAssetDetails);
            this.Controls.Add(this.grpDetectedHardware);
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
            this.grpDetectedHardware.ResumeLayout(false);
            this.grpDetectedHardware.PerformLayout();
            this.grpAssetDetails.ResumeLayout(false);
            this.grpAssetDetails.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpDetectedHardware;
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.Label lblHardwareType;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtHardwareType;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtSystemName;
        private System.Windows.Forms.Button btnRefreshHardware;
        private System.Windows.Forms.GroupBox grpAssetDetails;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.ComboBox cmbAssignedEmployee;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnAddAsset;
        private System.Windows.Forms.Button btnUpdateAsset;
        private System.Windows.Forms.Button btnDeleteAsset;
        private System.Windows.Forms.Button btnClearAsset;
        private System.Windows.Forms.Label lblAssignedEmployee;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblNotes;
    }
}
