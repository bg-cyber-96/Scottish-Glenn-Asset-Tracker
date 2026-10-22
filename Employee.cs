using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Scottish_Glen_Asset_Tracking
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }
}
