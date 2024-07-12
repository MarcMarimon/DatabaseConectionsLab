using DatabaseConections;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DatabaseConnections
{
    public partial class ListEmployeesForm : Form
    {
        private DalEmployee dalEmployee;

        public ListEmployeesForm()
        {
            InitializeComponent();
            dalEmployee = new DalEmployee();
        }

        private void FormListarEmpleados_Load(object sender, EventArgs e)
        {
            List<Employee> employees = dalEmployee.GetAll();
            if (employees == null)
            {
                MessageBox.Show("Error al cargar los empleados.");
                return;
            }

            foreach (var employee in employees)
            {
                lstEmpleados.Items.Add($"{employee.FirstName} {employee.LastName} - {employee.Email}");
            }
        }
    }
}
