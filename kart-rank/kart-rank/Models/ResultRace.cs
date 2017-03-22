using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kart_rank.Models
{
    public class ResultRace
    {
        public int Position { get; set; }
        public long PilotId { get; set; }
        public String PilotName { get; set; }
        public int TotalTurns { get; set; }
        public TimeSpan TotalTime { get; set; }
    }
}