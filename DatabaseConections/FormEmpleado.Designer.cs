namespace DatabaseConnections
{
    partial class FormEmpleado
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtManagerId;
        private System.Windows.Forms.ComboBox cmbJobId; 
        private System.Windows.Forms.ComboBox cmbDepartmentId;
        private System.Windows.Forms.Button btnGuardar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtManagerId = new System.Windows.Forms.TextBox();
            this.cmbJobId = new System.Windows.Forms.ComboBox(); 
            this.cmbDepartmentId = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(29, 44);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 26);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(29, 84);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 26);
            this.txtLastName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(29, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(29, 164);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(150, 26);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(29, 204);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 26);
            this.dtpHireDate.TabIndex = 4;
            
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(271, 84);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(150, 26);
            this.txtSalary.TabIndex = 6;
            // 
            // txtManagerId
            // 
            this.txtManagerId.Location = new System.Drawing.Point(271, 124);
            this.txtManagerId.Name = "txtManagerId";
            this.txtManagerId.Size = new System.Drawing.Size(150, 26);
            this.txtManagerId.TabIndex = 7;
            // 

            // cmbJobId
            // 
            this.cmbJobId.FormattingEnabled = true;
            this.cmbJobId.Location = new System.Drawing.Point(271, 44);
            this.cmbJobId.Name = "cmbJobId";
            this.cmbJobId.Size = new System.Drawing.Size(150, 28);
            this.cmbJobId.TabIndex = 5;
            // 
            // cmbDepartmentId
            // 
            this.cmbDepartmentId.FormattingEnabled = true;
            this.cmbDepartmentId.Location = new System.Drawing.Point(271, 164);
            this.cmbDepartmentId.Name = "cmbDepartmentId";
            this.cmbDepartmentId.Size = new System.Drawing.Size(150, 28);
            this.cmbDepartmentId.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(170, 264);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 50);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbDepartmentId);
            this.Controls.Add(this.txtManagerId);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.cmbJobId);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "FormEmpleado";
            this.Text = "FormEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
