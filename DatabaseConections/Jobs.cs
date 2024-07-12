using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConections
{
    public class Job
    {
        private int jobId;
        private string jobTitle;
        private decimal? minSalary;
        private decimal? maxSalary;

      

        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }

        public Job()
        {
        }
        public Job(int jobId, string jobTitle, decimal? minSalary, decimal? maxSalary)
        {
            this.jobId = jobId;
            this.jobTitle = jobTitle;
            this.minSalary = minSalary;
            this.maxSalary = maxSalary;
        }
    }
}
