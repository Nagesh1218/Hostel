using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelDb.Models
{
    public class HostelDetails
    {
        public int HostelId { get; set; }
        public string HostelName { get; set; }       
        public string OwnerName { get; set; }
        public string ContactNumber { get; set; }
        public string OwnerEmailId { get; set; }
        public string Registeredumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string LatLong { get; set; }
        public byte[] Photo { get; set; }

        public Membership Membership { get; set; }

        public Category Category { get; set; }
    }
}
