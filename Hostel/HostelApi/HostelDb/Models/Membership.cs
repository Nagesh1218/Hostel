using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelDb.Models
{
    public class Membership
    {
        public int MembershipId { get; set; }
        public string MembershipName { get; set; }
        public ICollection<HostelDetails> HostelDetailsList { get; set; }
    }
}
