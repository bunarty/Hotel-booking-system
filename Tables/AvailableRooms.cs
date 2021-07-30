using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bay_View_Hotel.Tables
{
    public class AvailableRooms
    {
        public int RoomNo { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
        public string RoomType { get; set; }

    }
}
