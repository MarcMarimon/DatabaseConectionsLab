namespace DatabaseConnections
{
    partial class FormDataBase
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCrearEmpleado;
        private System.Windows.Forms.Button btnListarEmpleados;
        private System.Windows.Forms.Button btnListarDepartamentos;
        private System.Windows.Forms.Button btnListarJobs;
        private System.Windows.Forms.Button btnCerrarLimpiar;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstDatos;

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
            this.btnListarDepartamentos = new System.Windows.Forms.Button();
            this.btnListarJobs = new System.Windows.Forms.Button();
            this.btnCerrarLimpiar = new System.Windows.Forms.Button();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Location = new System.Drawing.Point(13, 13);
            this.btnCrearEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(100, 32);
            this.btnCrearEmpleado.TabIndex = 0;
            this.btnCrearEmpleado.Text = "Crear Empleado";
            this.btnCrearEmpleado.UseVisualStyleBackColor = true;
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
            // 
            // btnListarEmpleados
            // 
            this.btnListarEmpleados.Location = new System.Drawing.Point(133, 13);
            this.btnListarEmpleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarEmpleados.Name = "btnListarEmpleados";
            this.btnListarEmpleados.Size = new System.Drawing.Size(100, 32);
            this.btnListarEmpleados.TabIndex = 1;
            this.btnListarEmpleados.Text = "Listar Empleados";
            this.btnListarEmpleados.UseVisualStyleBackColor = true;
            this.btnListarEmpleados.Click += new System.EventHandler(this.btnListarEmpleados_Click);
            // 
            // btnListarDepartamentos
            // 
            this.btnListarDepartamentos.Location = new System.Drawing.Point(253, 13);
            this.btnListarDepartamentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarDepartamentos.Name = "btnListarDepartamentos";
            this.btnListarDepartamentos.Size = new System.Drawing.Size(120, 32);
            this.btnListarDepartamentos.TabIndex = 2;
            this.btnListarDepartamentos.Text = "Listar Departamentos";
            this.btnListarDepartamentos.UseVisualStyleBackColor = true;
            this.btnListarDepartamentos.Click += new System.EventHandler(this.btnListarDepartamentos_Click);
            // 
            // btnListarJobs
            // 
            this.btnListarJobs.Location = new System.Drawing.Point(392, 13);
            this.btnListarJobs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarJobs.Name = "btnListarJobs";
            this.btnListarJobs.Size = new System.Drawing.Size(100, 32);
            this.btnListarJobs.TabIndex = 3;
            this.btnListarJobs.Text = "Listar Jobs";
            this.btnListarJobs.UseVisualStyleBackColor = true;
            this.btnListarJobs.Click += new System.EventHandler(this.btnListarJobs_Click);
            // 
            // btnCerrarLimpiar
            // 
            this.btnCerrarLimpiar.Location = new System.Drawing.Point(511, 13);
            this.btnCerrarLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarLimpiar.Name = "btnCerrarLimpiar";
            this.btnCerrarLimpiar.Size = new System.Drawing.Size(89, 32);
            this.btnCerrarLimpiar.TabIndex = 4;
            this.btnCerrarLimpiar.Text = "Cerrar/Limpiar";
            this.btnCerrarLimpiar.UseVisualStyleBackColor = true;
            this.btnCerrarLimpiar.Click += new System.EventHandler(this.btnCerrarLimpiar_Click);
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormulario.AutoScroll = true;
            this.pnlFormulario.Location = new System.Drawing.Point(13, 58);
            this.pnlFormulario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(587, 260);
            this.pnlFormulario.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 46);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 17);
            this.lblTitulo.TabIndex = 6;
            // 
            // lstDatos
            // 
            this.lstDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(13, 65);
            this.lstDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(588, 212);
            this.lstDatos.TabIndex = 7;
            // 
            // FormDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 332);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.btnCerrarLimpiar);
            this.Controls.Add(this.btnListarJobs);
            this.Controls.Add(this.btnListarDepartamentos);
            this.Controls.Add(this.btnListarEmpleados);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDataBase";
            this.Text = "FormDatabase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
