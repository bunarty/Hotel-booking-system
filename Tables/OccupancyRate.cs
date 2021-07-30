using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bay_View_Hotel.Tables
{
    public class OccupancyRate
    {
        public int MonthNo { get; set; }
        public string MonthName { get; set; }
        public int TotalNightsForMonth { get; set; }
        public int NumberNightsAvailable { get; set; }
        public decimal OccupancyRateValue { get; set; }
    }
}
