using DatabaseConections;
using System;
using System.Windows.Forms;

namespace DatabaseConnections
{
    public partial class FormDataBase : Form
    {
        public FormDataBase()
        {
            InitializeComponent();
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            MostrarFormularioEmpleado();
        }

        private void btnListarEmpleados_Click(object sender, EventArgs e)
        {
            MostrarFormularioListarEmpleados();
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

        private void MostrarFormularioListarEmpleados()
        {
            pnlFormularioEmpleado.Controls.Clear();
            var listEmployeesForm = new ListEmployeesForm();
            listEmployeesForm.TopLevel = false;
            listEmployeesForm.FormBorderStyle = FormBorderStyle.None;
            listEmployeesForm.Dock = DockStyle.Fill;
            pnlFormularioEmpleado.Controls.Add(listEmployeesForm);
            listEmployeesForm.Show();
        }
    }
}
