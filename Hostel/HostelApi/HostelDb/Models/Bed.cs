using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelDb.Models
{
    public class Bed
    {
        public int BedId { get; set; }

        public int BedNumber { get; set; }

        public Room Room { get; set; }
    }
}
