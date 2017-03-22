using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kart_rank.Models
{
    public class Race
    {
        public int ArrivalPosition { get; set; }
        public long PilotId { get; set; }
        public String PilotName { get; set; }
        public int LapsCompleted { get; set; }
        public TimeSpan TotalRunTime { get; set; }
    }
}