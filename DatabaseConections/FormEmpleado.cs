using DatabaseConections;
using DatabaseConnections;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DatabaseConnections
{
    public partial class FormEmpleado : Form
    {
        private Servicios servicios;
        private Employee empleadoModificar; 

        public FormEmpleado(Employee empleado = null)
        {
            InitializeComponent();
            servicios = new Servicios();

            if (empleado != null)
            {
                empleadoModificar = empleado;
                CargarDatosEmpleado(empleado);
            }
            else
            {
                empleadoModificar = null;
                SetPlaceholderText();
            }

            CargarComboBoxes();
        }

        private void SetPlaceholderText()
        {
            SetPlaceholder(txtFirstName, "First Name");
            SetPlaceholder(txtLastName, "Last Name");
            SetPlaceholder(txtEmail, "Email");
            SetPlaceholder(txtPhoneNumber, "Phone Number");
            SetPlaceholder(txtSalary, "Salary");
            SetPlaceholder(txtManagerId, "Manager ID");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void CargarComboBoxes()
        {
            var departments = servicios.GetAllDepartments();
            cmbDepartmentId.DisplayMember = "DepartmentName";
            cmbDepartmentId.ValueMember = "DepartmentId";
            cmbDepartmentId.DataSource = departments;

            var jobs = servicios.GetAllJobs();
            cmbJobId.DisplayMember = "JobTitle";
            cmbJobId.ValueMember = "JobId";
            cmbJobId.DataSource = jobs;
        }

        private void CargarDatosEmpleado(Employee empleado)
        {
            txtFirstName.Text = empleado.FirstName;
            txtLastName.Text = empleado.LastName;
            txtEmail.Text = empleado.Email;
            txtPhoneNumber.Text = empleado.PhoneNumber;
            dtpHireDate.Value = empleado.HireDate;
            cmbJobId.SelectedValue = empleado.JobId;
            txtSalary.Text = empleado.Salary.ToString();
            txtManagerId.Text = empleado.ManagerId.HasValue ? empleado.ManagerId.ToString() : "";
            cmbDepartmentId.SelectedValue = empleado.DepartmentId;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Employee empleado = new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                HireDate = DateTime.Parse(dtpHireDate.Text),
                JobId = (int)cmbJobId.SelectedValue,
                Salary = decimal.Parse(txtSalary.Text),
                ManagerId = string.IsNullOrEmpty(txtManagerId.Text) ? (int?)null : int.Parse(txtManagerId.Text),
                DepartmentId = (int)cmbDepartmentId.SelectedValue
            };

            bool success = false;
            if (empleadoModificar == null)
            {
                success = servicios.InsertEmployee(empleado);
            }
            else
            {
                empleado.EmployeeId = empleadoModificar.EmployeeId; 
                success = servicios.UpdateEmployee(empleado);
            }

            if (success)
            {
                MessageBox.Show("Empleado guardado correctamente en la base de datos.");
                SetPlaceholderText();
                Close(); 
            }
            else
            {
                MessageBox.Show("No se pudo guardar el empleado en la base de datos.");
            }
        }
    }
}
