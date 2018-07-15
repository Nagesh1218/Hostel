using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelDb.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public int TotalBeds { get; set; }
        public int TotalOccupied { get; set; }
        public bool IsFull { get; set; }
        public Floor Floor { get; set; }
    }
}
