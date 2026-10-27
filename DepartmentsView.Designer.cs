namespace Scottish_Glen_Asset_Tracking
{
    partial class DepartmentsView
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
            this.lblDepartmentsTitle = new System.Windows.Forms.Label();
            this.lblDepartmentsSubtitle = new System.Windows.Forms.Label();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartmentsTitle
            // 
            this.lblDepartmentsTitle.AutoSize = true;
            this.lblDepartmentsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.lblDepartmentsTitle.Location = new System.Drawing.Point(25, 17);
            this.lblDepartmentsTitle.Name = "lblDepartmentsTitle";
            this.lblDepartmentsTitle.Size = new System.Drawing.Size(202, 41);
            this.lblDepartmentsTitle.TabIndex = 0;
            this.lblDepartmentsTitle.Text = "Departments";
            // 
            // lblDepartmentsSubtitle
            // 
            this.lblDepartmentsSubtitle.AutoSize = true;
            this.lblDepartmentsSubtitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentsSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblDepartmentsSubtitle.Location = new System.Drawing.Point(29, 58);
            this.lblDepartmentsSubtitle.Name = "lblDepartmentsSubtitle";
            this.lblDepartmentsSubtitle.Size = new System.Drawing.Size(373, 23);
            this.lblDepartmentsSubtitle.TabIndex = 1;
            this.lblDepartmentsSubtitle.Text = "View the available departments in Scottish Glen";
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.AllowUserToAddRows = false;
            this.dgvDepartments.AllowUserToDeleteRows = false;
            this.dgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartments.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(32, 118);
            this.dgvDepartments.MultiSelect = false;
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.ReadOnly = true;
            this.dgvDepartments.RowHeadersWidth = 51;
            this.dgvDepartments.RowTemplate.Height = 24;
            this.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartments.Size = new System.Drawing.Size(548, 225);
            this.dgvDepartments.TabIndex = 2;
            // 
            // DepartmentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDepartments);
            this.Controls.Add(this.lblDepartmentsSubtitle);
            this.Controls.Add(this.lblDepartmentsTitle);
            this.Name = "DepartmentsView";
            this.Size = new System.Drawing.Size(1109, 735);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartmentsTitle;
        private System.Windows.Forms.Label lblDepartmentsSubtitle;
        private System.Windows.Forms.DataGridView dgvDepartments;
    }
}
