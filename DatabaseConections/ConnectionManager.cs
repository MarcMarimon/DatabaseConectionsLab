using DatabaseConections;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DatabaseConnections
{
    public class ConnectionManager
    {
        private string connectionString;

        public ConnectionManager()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        }

        public bool InsertEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"INSERT INTO employees 
                                     (first_name, last_name, email, phone_number, hire_date, job_id, salary, manager_id, department_id) 
                                     VALUES 
                                     (@FirstName, @LastName, @Email, @PhoneNumber, @HireDate, @JobId, @Salary, @ManagerId, @DepartmentId)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    command.Parameters.AddWithValue("@LastName", employee.LastName);
                    command.Parameters.AddWithValue("@Email", employee.Email);
                    command.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                    command.Parameters.AddWithValue("@HireDate", employee.HireDate);
                    command.Parameters.AddWithValue("@JobId", employee.JobId);
                    command.Parameters.AddWithValue("@Salary", employee.Salary);
                    command.Parameters.AddWithValue("@ManagerId", employee.ManagerId);
                    command.Parameters.AddWithValue("@DepartmentId", employee.DepartmentId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar empleado en la base de datos: ", ex);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
