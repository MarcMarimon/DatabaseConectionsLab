namespace DatabaseConnections
{
    partial class FormDataBase
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCrearEmpleado;
        private System.Windows.Forms.Button btnListarEmpleados;
        private System.Windows.Forms.Panel pnlFormularioEmpleado;

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
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.btnListarEmpleados = new System.Windows.Forms.Button();
            this.pnlFormularioEmpleado = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Location = new System.Drawing.Point(20, 31);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(150, 50);
            this.btnCrearEmpleado.TabIndex = 2;
            this.btnCrearEmpleado.Text = "Crear Empleado";
            this.btnCrearEmpleado.UseVisualStyleBackColor = true;
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
            // 
            // btnListarEmpleados
            // 
            this.btnListarEmpleados.Location = new System.Drawing.Point(200, 31);
            this.btnListarEmpleados.Name = "btnListarEmpleados";
            this.btnListarEmpleados.Size = new System.Drawing.Size(150, 50);
            this.btnListarEmpleados.TabIndex = 3;
            this.btnListarEmpleados.Text = "Listar Empleados";
            this.btnListarEmpleados.UseVisualStyleBackColor = true;
            this.btnListarEmpleados.Click += new System.EventHandler(this.btnListarEmpleados_Click);
            // 
            // pnlFormularioEmpleado
            // 
            this.pnlFormularioEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormularioEmpleado.AutoScroll = true;
            this.pnlFormularioEmpleado.Location = new System.Drawing.Point(20, 106);
            this.pnlFormularioEmpleado.Name = "pnlFormularioEmpleado";
            this.pnlFormularioEmpleado.Size = new System.Drawing.Size(760, 396);
            this.pnlFormularioEmpleado.TabIndex = 4;
            // 
            // FormDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.pnlFormularioEmpleado);
            this.Controls.Add(this.btnListarEmpleados);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Name = "FormDataBase";
            this.Text = "FormDatabase";
            this.ResumeLayout(false);
        }
    }
}
