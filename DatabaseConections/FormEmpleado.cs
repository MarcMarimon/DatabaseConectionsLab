using DatabaseConections;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DatabaseConnections
{
    public partial class FormEmpleado : Form
    {
        private Servicios servicios;

        public FormEmpleado()
        {
            InitializeComponent();
            servicios = new Servicios(); 
            SetPlaceholderText();
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
                ManagerId = int.Parse(txtManagerId.Text),
                DepartmentId = (int)cmbDepartmentId.SelectedValue 
            };

            bool success = servicios.InsertEmployee(empleado);
            if (success)
            {
                MessageBox.Show("Empleado guardado correctamente en la base de datos.");
                SetPlaceholderText();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el empleado en la base de datos.");
            }
        }
    }
}
