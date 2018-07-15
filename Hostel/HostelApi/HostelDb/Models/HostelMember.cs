using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelDb.Models
{
    public class HostelMember
    {
        public int HostelMemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string EmailId { get; set; }
        public string GovtIDProof { get; set; }
        public string GovtIDProofNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }      
        public byte[] Photo { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string DateOfJoining { get; set; }
        public string FeeInAdvance { get; set; }
        public string Fee { get; set; }
        public string LatLong { get; set; }              
        public string SharingType { get; set; }
        public Bed Bed { get; set; }
        public Room Room { get; set; }
        public Floor Floor { get; set; }
        public HostelDetails HostelDetails { get; set; }
    }
}
