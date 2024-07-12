using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConections
{
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private DateTime hireDate;
        private int jobId;
        private decimal salary;
        private int? managerId;
        private int? departmentId;

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime HireDate { get => hireDate; set => hireDate = value; }
        public int JobId { get => jobId; set => jobId = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public int? ManagerId { get => managerId; set => managerId = value; }
        public int? DepartmentId { get => departmentId; set => departmentId = value; }

        public Employee()
        {

        }
        public Employee(int employeeId, string firstName, string lastName, string email, string phoneNumber, DateTime hireDate, int jobId, decimal salary, int? managerId, int? departmentId)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.hireDate = hireDate;
            this.jobId = jobId;
            this.salary = salary;
            this.managerId = managerId;
            this.departmentId = departmentId;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} -- {Email}";
        }
    }

}

