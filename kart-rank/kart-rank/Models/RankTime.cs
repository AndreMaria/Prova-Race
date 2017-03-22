using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kart_rank.Models
{
    public class RankTime
    {
        public long PilotId { get; set; }
        public String PilotName { get; set; }
        public List<TimeSpan> Turns { get; set; }
        public List<Decimal> ListSpeed { get; set; }
    }
}