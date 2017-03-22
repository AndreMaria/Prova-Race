using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kart_rank.Models
{
    public class KartLog
    {
        public TimeSpan Hour { get; set; }
        public long PilotId { get; set; }
        public String PilotName { get; set; }
        public int NTurn { get; set; }
        public TimeSpan Time { get; set; }
        public Decimal AverageSpeed { get; set; }
    }
}