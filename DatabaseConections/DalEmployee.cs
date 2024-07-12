using DatabaseConnections;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConections
{
    public class DalEmployee
    {
        private ConnectionManager connectionManager;
        private SqlConnection dataConnection;

        public DalEmployee()
        {
            connectionManager = new ConnectionManager();
            dataConnection = connectionManager.DataConnection;
        }
        public bool Insert(Employee employee)
        {
            {
                try
                {
                    string query = @"INSERT INTO employees 
                                     (first_name, last_name, email, phone_number, hire_date, job_id, salary, manager_id, department_id) 
                                     VALUES 
                                     (@FirstName, @LastName, @Email, @PhoneNumber, @HireDate, @JobId, @Salary, @ManagerId, @DepartmentId)";

                    SqlCommand command = new SqlCommand(query, dataConnection);
                    command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    command.Parameters.AddWithValue("@LastName", employee.LastName);
                    command.Parameters.AddWithValue("@Email", employee.Email);
                    command.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                    command.Parameters.AddWithValue("@HireDate", employee.HireDate);
                    command.Parameters.AddWithValue("@JobId", employee.JobId);
                    command.Parameters.AddWithValue("@Salary", employee.Salary);
                    command.Parameters.AddWithValue("@ManagerId", employee.ManagerId);
                    command.Parameters.AddWithValue("@DepartmentId", employee.DepartmentId);

                    dataConnection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    if (dataConnection.State == System.Data.ConnectionState.Open)
                    {
                        dataConnection.Close();
                    }
                }
            }
        }
        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                string query = "SELECT * FROM employees";
                SqlCommand command = new SqlCommand(query, dataConnection);

                dataConnection.Open();
                SqlDataReader records = command.ExecuteReader();

                while (records.Read())
                {
                    Employee employee = new Employee();

                    // Leer y asignar campos individualmente con verificaciones de valores nulos
                    employee.EmployeeId = records.GetInt32(records.GetOrdinal("employee_id"));
                    employee.FirstName = records.IsDBNull(records.GetOrdinal("first_name")) ? null : records.GetString(records.GetOrdinal("first_name"));
                    employee.LastName = records.GetString(records.GetOrdinal("last_name"));
                    employee.Email = records.GetString(records.GetOrdinal("email"));
                    employee.PhoneNumber = records.IsDBNull(records.GetOrdinal("phone_number")) ? null : records.GetString(records.GetOrdinal("phone_number"));
                    employee.HireDate = records.GetDateTime(records.GetOrdinal("hire_date"));
                    employee.JobId = records.GetInt32(records.GetOrdinal("job_id"));
                    employee.Salary = records.GetDecimal(records.GetOrdinal("salary"));
                    employee.ManagerId = records.IsDBNull(records.GetOrdinal("manager_id")) ? (int?)null : records.GetInt32(records.GetOrdinal("manager_id"));
                    employee.DepartmentId = records.IsDBNull(records.GetOrdinal("department_id")) ? (int?)null : records.GetInt32(records.GetOrdinal("department_id"));

                    employees.Add(employee);
                }
                records.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (dataConnection.State == System.Data.ConnectionState.Open)
                {
                    dataConnection.Close();
                }
            }
            return employees;
        }
    }
}
