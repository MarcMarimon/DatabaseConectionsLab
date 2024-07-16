using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConections
{
    internal class Servicios
    {
        private DalEmployee dalEmployee;
        private DalDepartment dalDepartment;
        private DalJob dalJob;

        public Servicios()
        {
            dalEmployee = new DalEmployee();
            dalDepartment = new DalDepartment();
            dalJob = new DalJob();
        }

        public List<Employee> GetAllEmployees()
        {
            return  dalEmployee.GetAll();
        }

        public List <Department> GetAllDepartments()
        {
            return dalDepartment.GetAll();
        }
        public List<Job> GetAllJobs()
        {
            return dalJob.GetAll();
        }
        public bool InsertEmployee(Employee employee)
        {
            return dalEmployee.Insert(employee);
        }
        public Employee GetEmployeeById(int employeeId)
        {
            return dalEmployee.GetById(employeeId);
        }

        public bool UpdateEmployee(Employee employee)
        {
            return dalEmployee.Update(employee);
        }
    }
}
