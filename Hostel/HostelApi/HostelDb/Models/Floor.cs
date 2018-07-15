using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelDb.Models
{
    public class Floor
    {
        public int FloorId { get; set; }
        public int FloorNumber { get; set; }
        public int TotalRooms { get; set; }
        public int TotalOccupied { get; set; }
        public bool IsFull { get; set; }

    }
}
