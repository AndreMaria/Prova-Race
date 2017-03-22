using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kart_rank.Models
{
    public class Records
    {
        public long PilotId { get; set; }
        public String PilotName { get; set; }
        public TimeSpan TotalTime { get; set; }
        public TimeSpan TimeMax { get; set; }
        public TimeSpan TimeMim { get; set; }
        public int BestLap { get; set; }
        public List<TimeSpan> Turns { get; set; }
        public List<Decimal> ListSpeed { get; set; }
        public decimal AverageSpeed { get; set; }
    }
}