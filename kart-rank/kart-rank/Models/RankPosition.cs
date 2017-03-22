using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kart_rank.Models
{
    public class RankPosition
    {
        public long PilotId { get; set; }
        public String PilotName { get; set; }
        public TimeSpan TotalTime { get; set; }
        public int PositionId { get; set; }
    }
}