using DatabaseConections;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DatabaseConnections
{
    public partial class FormDataBase : Form
    {
        private ConnectionManager connectionManager;

        public FormDataBase()
        {
            InitializeComponent();
            connectionManager = new ConnectionManager(); 

        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            MostrarFormularioEmpleado();
        }

        private void MostrarFormularioEmpleado()
        {
            pnlFormularioEmpleado.Controls.Clear();
            var formEmpleado = new FormEmpleado();
            formEmpleado.TopLevel = false;
            formEmpleado.FormBorderStyle = FormBorderStyle.None;
            formEmpleado.Dock = DockStyle.Fill;
            pnlFormularioEmpleado.Controls.Add(formEmpleado);
            formEmpleado.Show();
        }
    }
}
