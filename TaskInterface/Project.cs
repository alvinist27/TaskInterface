using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskInterface
{
    public class Project
    {
        public Guid ProjectID { get; set; }
        public string PName { get; set; }
        public List<Mission> Missions { get; set; }
    }
}
