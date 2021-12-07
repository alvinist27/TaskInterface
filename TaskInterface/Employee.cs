using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInterface
{
    public class Employee
    {
        public Guid EmployeeID { get; set; }
        public string EName { get; set; }
        public string EWork { get; set; }
        public List<Mission> Missions { get; set; }
    }
}
