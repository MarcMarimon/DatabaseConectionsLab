using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConections
{
    public class Department
    {
        private int departmentId;
        private string departmentName;
        private int locationId;
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int LocationId { get; set; }

        public Department() { }

        public Department(int departmentId, string departmentName, int locationId)
        {
            this.departmentId = departmentId;
            this.departmentName = departmentName;
            this.locationId = locationId;
        }
    }
}
