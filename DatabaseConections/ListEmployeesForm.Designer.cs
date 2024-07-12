namespace DatabaseConnections
{
    partial class ListEmployeesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstEmpleados;

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
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.ItemHeight = 20;
            this.lstEmpleados.Location = new System.Drawing.Point(12, 12);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(754, 464);
            this.lstEmpleados.TabIndex = 0;
            // 
            // ListEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 497);
            this.Controls.Add(this.lstEmpleados);
            this.Name = "ListEmployeesForm";
            this.Text = "Lista de Empleados";
            this.Load += new System.EventHandler(this.FormListarEmpleados_Load);
            this.ResumeLayout(false);
        }
    }
}
