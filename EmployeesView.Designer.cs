namespace Scottish_Glen_Asset_Tracking
{
    partial class EmployeesView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEmployeesTitle = new System.Windows.Forms.Label();
            this.lblEmployeesDescription = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.pnlEmployeeDetails = new System.Windows.Forms.Panel();
            this.btnClearEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblEmployeeDetailsTitle = new System.Windows.Forms.Label();
            this.pnlTotalEmployees = new System.Windows.Forms.Panel();
            this.lblTotalEmployeeCount = new System.Windows.Forms.Label();
            this.lblTotalEmployeesTitle = new System.Windows.Forms.Label();
            this.pnlTotalDepartments = new System.Windows.Forms.Panel();
            this.lblTotalDepartmentsCount = new System.Windows.Forms.Label();
            this.lblTotalDepartmentsTitle = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.pnlEmployeeDetails.SuspendLayout();
            this.pnlTotalEmployees.SuspendLayout();
            this.pnlTotalDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeesTitle
            // 
            this.lblEmployeesTitle.AutoSize = true;
            this.lblEmployeesTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.lblEmployeesTitle.Location = new System.Drawing.Point(37, 19);
            this.lblEmployeesTitle.Name = "lblEmployeesTitle";
            this.lblEmployeesTitle.Size = new System.Drawing.Size(350, 41);
            this.lblEmployeesTitle.TabIndex = 0;
            this.lblEmployeesTitle.Text = "Employee Management";
            // 
            // lblEmployeesDescription
            // 
            this.lblEmployeesDescription.AutoSize = true;
            this.lblEmployeesDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeesDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmployeesDescription.Location = new System.Drawing.Point(40, 69);
            this.lblEmployeesDescription.Name = "lblEmployeesDescription";
            this.lblEmployeesDescription.Size = new System.Drawing.Size(320, 23);
            this.lblEmployeesDescription.TabIndex = 1;
            this.lblEmployeesDescription.Text = "Add, edit and manage employee records";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(3, 67);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(92, 23);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(424, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(91, 23);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 151);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(114, 23);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email address";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(424, 151);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(102, 23);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(7, 94);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(245, 30);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(428, 94);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(246, 30);
            this.txtLastName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(7, 178);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 30);
            this.txtEmail.TabIndex = 8;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(428, 178);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(246, 31);
            this.cmbDepartment.TabIndex = 9;
            // 
            // pnlEmployeeDetails
            // 
            this.pnlEmployeeDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlEmployeeDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmployeeDetails.Controls.Add(this.btnClearEmployee);
            this.pnlEmployeeDetails.Controls.Add(this.btnDeleteEmployee);
            this.pnlEmployeeDetails.Controls.Add(this.btnUpdateEmployee);
            this.pnlEmployeeDetails.Controls.Add(this.btnAddEmployee);
            this.pnlEmployeeDetails.Controls.Add(this.lblEmployeeDetailsTitle);
            this.pnlEmployeeDetails.Controls.Add(this.lblFirstName);
            this.pnlEmployeeDetails.Controls.Add(this.cmbDepartment);
            this.pnlEmployeeDetails.Controls.Add(this.txtFirstName);
            this.pnlEmployeeDetails.Controls.Add(this.lblDepartment);
            this.pnlEmployeeDetails.Controls.Add(this.txtEmail);
            this.pnlEmployeeDetails.Controls.Add(this.lblLastName);
            this.pnlEmployeeDetails.Controls.Add(this.txtLastName);
            this.pnlEmployeeDetails.Controls.Add(this.lblEmail);
            this.pnlEmployeeDetails.Location = new System.Drawing.Point(44, 215);
            this.pnlEmployeeDetails.Margin = new System.Windows.Forms.Padding(12);
            this.pnlEmployeeDetails.Name = "pnlEmployeeDetails";
            this.pnlEmployeeDetails.Size = new System.Drawing.Size(723, 306);
            this.pnlEmployeeDetails.TabIndex = 10;
            // 
            // btnClearEmployee
            // 
            this.btnClearEmployee.BackColor = System.Drawing.Color.White;
            this.btnClearEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.btnClearEmployee.Location = new System.Drawing.Point(442, 232);
            this.btnClearEmployee.Name = "btnClearEmployee";
            this.btnClearEmployee.Size = new System.Drawing.Size(122, 44);
            this.btnClearEmployee.TabIndex = 14;
            this.btnClearEmployee.Text = "Clear Fields";
            this.btnClearEmployee.UseVisualStyleBackColor = false;
            this.btnClearEmployee.Click += new System.EventHandler(this.btnClearEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(296, 232);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(131, 44);
            this.btnDeleteEmployee.TabIndex = 13;
            this.btnDeleteEmployee.Text = "Delete Selected";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.White;
            this.btnUpdateEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            this.btnUpdateEmployee.Location = new System.Drawing.Point(149, 232);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(131, 44);
            this.btnUpdateEmployee.TabIndex = 12;
            this.btnUpdateEmployee.Text = "Update Selected";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(7, 232);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(124, 44);
            this.btnAddEmployee.TabIndex = 11;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lblEmployeeDetailsTitle
            // 
            this.lblEmployeeDetailsTitle.AutoSize = true;
            this.lblEmployeeDetailsTitle.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDetailsTitle.Location = new System.Drawing.Point(17, 9);
            this.lblEmployeeDetailsTitle.Name = "lblEmployeeDetailsTitle";
            this.lblEmployeeDetailsTitle.Size = new System.Drawing.Size(178, 31);
            this.lblEmployeeDetailsTitle.TabIndex = 10;
            this.lblEmployeeDetailsTitle.Text = "Employee details";
            // 
            // pnlTotalEmployees
            // 
            this.pnlTotalEmployees.BackColor = System.Drawing.Color.White;
            this.pnlTotalEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalEmployees.Controls.Add(this.lblTotalEmployeeCount);
            this.pnlTotalEmployees.Controls.Add(this.lblTotalEmployeesTitle);
            this.pnlTotalEmployees.Location = new System.Drawing.Point(44, 95);
            this.pnlTotalEmployees.Name = "pnlTotalEmployees";
            this.pnlTotalEmployees.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTotalEmployees.Size = new System.Drawing.Size(313, 105);
            this.pnlTotalEmployees.TabIndex = 11;
            // 
            // lblTotalEmployeeCount
            // 
            this.lblTotalEmployeeCount.AutoSize = true;
            this.lblTotalEmployeeCount.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployeeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.lblTotalEmployeeCount.Location = new System.Drawing.Point(15, 44);
            this.lblTotalEmployeeCount.Name = "lblTotalEmployeeCount";
            this.lblTotalEmployeeCount.Size = new System.Drawing.Size(43, 50);
            this.lblTotalEmployeeCount.TabIndex = 0;
            this.lblTotalEmployeeCount.Text = "0";
            // 
            // lblTotalEmployeesTitle
            // 
            this.lblTotalEmployeesTitle.AutoSize = true;
            this.lblTotalEmployeesTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalEmployeesTitle.Location = new System.Drawing.Point(15, 21);
            this.lblTotalEmployeesTitle.Name = "lblTotalEmployeesTitle";
            this.lblTotalEmployeesTitle.Size = new System.Drawing.Size(132, 23);
            this.lblTotalEmployeesTitle.TabIndex = 0;
            this.lblTotalEmployeesTitle.Text = "Total Employees";
            // 
            // pnlTotalDepartments
            // 
            this.pnlTotalDepartments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalDepartments.Controls.Add(this.lblTotalDepartmentsCount);
            this.pnlTotalDepartments.Controls.Add(this.lblTotalDepartmentsTitle);
            this.pnlTotalDepartments.Location = new System.Drawing.Point(454, 95);
            this.pnlTotalDepartments.Name = "pnlTotalDepartments";
            this.pnlTotalDepartments.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTotalDepartments.Size = new System.Drawing.Size(313, 105);
            this.pnlTotalDepartments.TabIndex = 12;
            // 
            // lblTotalDepartmentsCount
            // 
            this.lblTotalDepartmentsCount.AutoSize = true;
            this.lblTotalDepartmentsCount.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDepartmentsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.lblTotalDepartmentsCount.Location = new System.Drawing.Point(9, 41);
            this.lblTotalDepartmentsCount.Name = "lblTotalDepartmentsCount";
            this.lblTotalDepartmentsCount.Size = new System.Drawing.Size(43, 50);
            this.lblTotalDepartmentsCount.TabIndex = 1;
            this.lblTotalDepartmentsCount.Text = "5";
            // 
            // lblTotalDepartmentsTitle
            // 
            this.lblTotalDepartmentsTitle.AutoSize = true;
            this.lblTotalDepartmentsTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalDepartmentsTitle.Location = new System.Drawing.Point(14, 21);
            this.lblTotalDepartmentsTitle.Name = "lblTotalDepartmentsTitle";
            this.lblTotalDepartmentsTitle.Size = new System.Drawing.Size(109, 23);
            this.lblTotalDepartmentsTitle.TabIndex = 0;
            this.lblTotalDepartmentsTitle.Text = "Departments";
            this.lblTotalDepartmentsTitle.Click += new System.EventHandler(this.lblTotalDepartmentsTitle_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.EnableHeadersVisualStyles = false;
            this.dgvEmployees.Location = new System.Drawing.Point(44, 560);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(723, 150);
            this.dgvEmployees.TabIndex = 13;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            // 
            // EmployeesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.pnlTotalDepartments);
            this.Controls.Add(this.pnlTotalEmployees);
            this.Controls.Add(this.pnlEmployeeDetails);
            this.Controls.Add(this.lblEmployeesDescription);
            this.Controls.Add(this.lblEmployeesTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeesView";
            this.Size = new System.Drawing.Size(1109, 735);
            this.pnlEmployeeDetails.ResumeLayout(false);
            this.pnlEmployeeDetails.PerformLayout();
            this.pnlTotalEmployees.ResumeLayout(false);
            this.pnlTotalEmployees.PerformLayout();
            this.pnlTotalDepartments.ResumeLayout(false);
            this.pnlTotalDepartments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeesTitle;
        private System.Windows.Forms.Label lblEmployeesDescription;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Panel pnlEmployeeDetails;
        private System.Windows.Forms.Label lblEmployeeDetailsTitle;
        private System.Windows.Forms.Panel pnlTotalEmployees;
        private System.Windows.Forms.Panel pnlTotalDepartments;
        private System.Windows.Forms.Label lblTotalEmployeesTitle;
        private System.Windows.Forms.Label lblTotalEmployeeCount;
        private System.Windows.Forms.Label lblTotalDepartmentsCount;
        private System.Windows.Forms.Label lblTotalDepartmentsTitle;
        private System.Windows.Forms.Button btnClearEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridView dgvEmployees;
    }
}
