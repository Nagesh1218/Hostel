using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelDb.Models
{
    public class HostelStaff
    {
        public int HostelStaffId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string EmailId { get; set; }
        public string Salary { get; set; }
        public string DateOfJoining { get; set; }
        public string Designation { get; set; }

        public HostelDetails HostelDetails { get; set; }

    }
}
