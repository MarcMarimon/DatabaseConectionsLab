using DatabaseConnections;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DatabaseConections
{
    public class DalJobs
    {
        private ConnectionManager connectionManager;
        private SqlConnection dataConnection;

        public DalJobs()
        {
            connectionManager = new ConnectionManager();
            dataConnection = connectionManager.DataConnection;
        }

        public List<Job> GetAllJobs()
        {
            List<Job> jobs = new List<Job>();
            try
            {
                string query = "SELECT * FROM jobs";
                SqlCommand command = new SqlCommand(query, dataConnection);

                dataConnection.Open();
                SqlDataReader records = command.ExecuteReader();

                while (records.Read())
                {
                    int jobId = records.GetInt32(records.GetOrdinal("job_id"));
                    string jobTitle = records.GetString(records.GetOrdinal("job_title"));
                    decimal? minSalary = records.IsDBNull(records.GetOrdinal("min_salary")) ? (decimal?)null : records.GetDecimal(records.GetOrdinal("min_salary"));
                    decimal? maxSalary = records.IsDBNull(records.GetOrdinal("max_salary")) ? (decimal?)null : records.GetDecimal(records.GetOrdinal("max_salary"));

                    Job job = new Job
                    {
                        JobId = jobId,
                        JobTitle = jobTitle,
                        MinSalary = minSalary,
                        MaxSalary = maxSalary
                    };

                    jobs.Add(job);
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
            return jobs;
        }
    }
}
