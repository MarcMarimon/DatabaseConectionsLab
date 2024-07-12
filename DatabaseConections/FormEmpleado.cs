using DatabaseConections;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DatabaseConnections

{
    public partial class FormEmpleado : Form
    {
        private DalEmployee dalEmployee;

        public FormEmpleado()
        {
            InitializeComponent();
            dalEmployee = new DalEmployee();
            SetPlaceholderText();
        }

        private void SetPlaceholderText()
        {
            SetPlaceholder(txtFirstName, "First Name");
            SetPlaceholder(txtLastName, "Last Name");
            SetPlaceholder(txtEmail, "Email");
            SetPlaceholder(txtPhoneNumber, "Phone Number");
            SetPlaceholder(txtJobId, "Job ID");
            SetPlaceholder(txtSalary, "Salary");
            SetPlaceholder(txtManagerId, "Manager ID");
            SetPlaceholder(txtDepartmentId, "Department ID");
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Employee empleado = new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                HireDate = DateTime.Parse(dtpHireDate.Text),
                JobId = int.Parse(txtJobId.Text),
                Salary = decimal.Parse(txtSalary.Text),
                ManagerId = int.Parse(txtManagerId.Text),
                DepartmentId = int.Parse(txtDepartmentId.Text)
            };

          
            bool success = dalEmployee.Insert(empleado);
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
