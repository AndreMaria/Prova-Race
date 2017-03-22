using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kart_rank.Service
{
    public class KartLog
    {
        public List<Models.Records> GetRecords()
        {
            Repository.KartLog _KartLog = new Repository.KartLog();
            List<Models.Records> listRecord = null;

            var rank = GetRankTime();

            if (null != rank)
            {
                listRecord = new List<Models.Records>();

                foreach (var item in rank)
                {
                    TimeSpan sum = GetTotalTime(item.Turns);
                    int index = 0;
                    listRecord.Add(new Models.Records()
                    {
                        PilotId = item.PilotId,
                        PilotName = item.PilotName,
                        TotalTime = sum,
                        TimeMax = item.Turns.Max<TimeSpan>(),
                        TimeMim = item.Turns.Min<TimeSpan>(),
                        BestLap = (
                                    from t in item.Turns
                                    select new { Time = t , id = (index = index + 1) }
                                   ).First( x=> x.Time == item.Turns.Min<TimeSpan>()).id,
                        Turns = item.Turns,
                        AverageSpeed = GetAverageSpeed(item.ListSpeed),
                        ListSpeed = item.ListSpeed
                    });

                    listRecord = listRecord.OrderBy(x => x.TotalTime).ToList();
                }
            }
            
            return listRecord;
        }

        public List<Models.RankPosition> GetRankPosition()
        {
            List<Models.RankPosition> RankPositions = null;
            var rank = GetRankTime();
            if (null != rank)
            {
                var Positions = new List<Models.RankPosition>();
                foreach (var item in rank)
                {
                    TimeSpan sum = GetTotalTime(item.Turns);
                    Positions.Add(new Models.RankPosition()
                    {
                        PilotId = item.PilotId,
                        PilotName = item.PilotName,
                        TotalTime = sum
                    });
                }
                int id = 0;
                RankPositions = Positions.OrderBy(x => x.TotalTime).Select(y => new Models.RankPosition()
                {
                    PilotId = y.PilotId,
                    PilotName = y.PilotName,
                    TotalTime = y.TotalTime,
                    PositionId = (id = id + 1)
                }).ToList();
            }
            return RankPositions;
        }

        public List<Models.Race> GetResultRace()
        {
            List<Models.Race> resultSets = null;

            List<Models.RankTime> rank = GetRankTime();
            if (null != rank)
            {
                var Positions = new List<Models.Race>();

                foreach (var item in rank)
                {
                    Positions.Add(new Models.Race()
                    {
                        PilotId = item.PilotId,
                        PilotName = item.PilotName,
                        LapsCompleted = item.Turns.Count,
                        TotalRunTime = GetTotalTime(item.Turns)
                    });
                }
                int id = 0;
                resultSets = Positions.OrderBy(x => x.TotalRunTime).Select(y => new Models.Race()
                {
                    PilotId = y.PilotId,
                    PilotName = y.PilotName,
                    TotalRunTime = y.TotalRunTime,
                    LapsCompleted = y.LapsCompleted,
                    ArrivalPosition = (id = id + 1)
                }).ToList();
            }
            return resultSets;
        }

        public List<Models.AfterWinner> GetResultAfterWinner()
        {
            List<Models.AfterWinner> listAfter = null;
            List<Models.Records> records = GetRecords();
            if (null != records)
            {
                Models.Records winner = records.FirstOrDefault();

                listAfter = (from aw in records
                             select new Models.AfterWinner()
                             {
                                 PilotId = aw.PilotId,
                                 PilotName = aw.PilotName,
                                 TotalTime = aw.TotalTime,
                                 TimeAfterWinner = (aw.TotalTime - winner.TotalTime)
                             }).ToList();

            }
            return listAfter;
        }

        private TimeSpan GetTotalTime(List<TimeSpan> Turns)
        {
            TimeSpan sum = new TimeSpan();
            if (null != Turns)
            {
                for (int i = 0; i < Turns.Count; i++)
                {
                    if (i == 0)
                    {
                        sum = Turns[i];
                    }
                    else
                    {
                        sum = sum + Turns[i];
                    }
                }
            }
            return sum;
        }

        private List<Models.RankTime> GetRankTime()
        {
            Repository.KartLog _KartLog = new Repository.KartLog();
            List<Models.KartLog> listKartLog = _KartLog.GetKartLog();
            List<Models.RankTime> rank = null;
            if (null != listKartLog)
            {
                rank = (from pilot in listKartLog
                            group pilot by pilot.PilotId into pilotGroup
                            select new Models.RankTime()
                            {
                                PilotId = pilotGroup.Key,
                                PilotName = pilotGroup.FirstOrDefault( x=> x.PilotId == pilotGroup.Key).PilotName,
                                Turns = pilotGroup.Select(x => x.Time).ToList(),
                                ListSpeed = pilotGroup.Select(x => x.AverageSpeed).ToList()
                            }).ToList();
            }
            return rank;
        }

        private Decimal GetAverageSpeed(List<decimal> ListSpeed)
        {
            decimal result = 0;
            if(null != ListSpeed)
            {
                result = (ListSpeed.Sum()/ListSpeed.Count);
            }
            return result;
        }

    }
}