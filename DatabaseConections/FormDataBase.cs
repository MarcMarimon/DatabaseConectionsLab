using DatabaseConections;
using System;
using System.Windows.Forms;

namespace DatabaseConnections
{
    public partial class FormDataBase : Form
    {
        private Servicios servicios;
        private bool listaVisible = false;
        private FormEmpleado formEmpleado;

        public bool ListaVisible
        {
            get => listaVisible;
            set
            {
                listaVisible = value;
                if (!value)
                {
                    lstDatos.DataSource = null;
                    lblTitulo.Text = null;
                }
            }
        }

        public FormDataBase()
        {
            InitializeComponent();
            servicios = new Servicios();
            OcultarListaYLimpiarBoton();
            lstDatos.SelectedIndexChanged += LstDatos_SelectedIndexChanged;
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            MostrarFormularioEmpleado(null);
            MostrarBotonCerrarLimpiar();
        }

        private void btnListarEmpleados_Click(object sender, EventArgs e)
        {
            MostrarLista(servicios.GetAllEmployees(), "NOMBRE COMPLETO -- EMAIL");
            MostrarBotonCerrarLimpiar();
        }

        private void btnListarDepartamentos_Click(object sender, EventArgs e)
        {
            MostrarLista(servicios.GetAllDepartments(), "NOMBRE DEPARTAMENTO -- LOCATION ID");
            MostrarBotonCerrarLimpiar();
        }

        private void btnListarJobs_Click(object sender, EventArgs e)
        {
            MostrarLista(servicios.GetAllJobs(), "POSICIÓN -- RANGO SALARIAL");
            MostrarBotonCerrarLimpiar();
        }

        private void btnCerrarLimpiar_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = string.Empty;
            lstDatos.DataSource = null;
            OcultarListaYLimpiarBoton();
            pnlFormulario.Controls.Clear();

            if (formEmpleado != null && !formEmpleado.IsDisposed)
            {
                formEmpleado.Close();
            }
        }

        private void MostrarFormularioEmpleado(Employee empleado)
        {
            OcultarListaYLimpiarBoton();
            pnlFormulario.Controls.Clear();
            formEmpleado = new FormEmpleado(empleado);
            formEmpleado.FormClosed += FormEmpleado_FormClosed;
            formEmpleado.TopLevel = false;
            formEmpleado.FormBorderStyle = FormBorderStyle.None;
            formEmpleado.Dock = DockStyle.Fill;
            pnlFormulario.Controls.Add(formEmpleado);
            formEmpleado.Show();
            lblTitulo.Text = "FORMULARIO EMPLEADO";
        }

        private void FormEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            OcultarBotonCerrarLimpiar();
            RefreshData();
        }

        private void MostrarLista(object dataSource, string titulo)
        {
            lblTitulo.Text = titulo;
            lstDatos.DataSource = null;
            lstDatos.DataSource = dataSource;
            MostrarListaYLimpiarBoton();
        }

        private void MostrarListaYLimpiarBoton()
        {
            lstDatos.Visible = true;
            btnCerrarLimpiar.Visible = true;
            ListaVisible = true;
        }

        private void OcultarListaYLimpiarBoton()
        {
            lstDatos.Visible = false;
            btnCerrarLimpiar.Visible = false;
            ListaVisible = false;
        }

        private void MostrarBotonCerrarLimpiar()
        {
            if (!ListaVisible)
            {
                btnCerrarLimpiar.Visible = true;
            }
        }

        private void OcultarBotonCerrarLimpiar()
        {
            btnCerrarLimpiar.Visible = false;
        }

        private void RefreshData()
        {
            if (lblTitulo.Text == "NOMBRE COMPLETO -- EMAIL")
            {
                btnListarEmpleados_Click(null, null);
            }
        }

        private void LstDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDatos.SelectedItem != null && lstDatos.SelectedItem is Employee selectedEmployee)
            {
                MostrarFormularioEmpleado(selectedEmployee);
            }
        }
    }
}
