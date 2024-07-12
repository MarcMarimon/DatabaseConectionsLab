using DatabaseConnections;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DatabaseConections
{
    public class DalDepartments
    {
        private ConnectionManager connectionManager;
        private SqlConnection dataConnection;

        public DalDepartments()
        {
            connectionManager = new ConnectionManager();
            dataConnection = connectionManager.DataConnection;
        }

        public List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();
            try
            {
                string query = "SELECT * FROM departments";
                SqlCommand command = new SqlCommand(query, dataConnection);

                dataConnection.Open();
                SqlDataReader records = command.ExecuteReader();

                while (records.Read())
                {
                    int departmentId = records.GetInt32(records.GetOrdinal("department_id"));
                    string departmentName = records.GetString(records.GetOrdinal("department_name"));
                    int locationId = records.GetInt32(records.GetOrdinal("location_id"));

                    Department department = new Department
                    {
                        DepartmentId = departmentId,
                        DepartmentName = departmentName,
                        LocationId = locationId
                    };

                    departments.Add(department);
                }
                records.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los departamentos", ex);
            }
            finally
            {
                if (dataConnection.State == System.Data.ConnectionState.Open)
                {
                    dataConnection.Close();
                }
            }
            return departments;
        }
    }
}
