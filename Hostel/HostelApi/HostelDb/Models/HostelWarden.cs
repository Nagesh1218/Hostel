using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelDb.Models
{
    public class HostelWarden
    {
        public int HostelWardenId { get; set; }
        public string WardenName { get; set; }
        public string ContactNumber { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public HostelDetails HostelDetails { get; set; }
    }
}
