using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kart_rank.Repository;
using kart_rank.Models;

namespace Kart_Rank_Test
{
    [TestClass]
    public class ServiceKartLogTest
    {
        [TestMethod]
        public void GetRankTime_GetKartLogNotNull()
        {
            List<kart_rank.Models.KartLog> GetKartLog = null;
            Assert.IsNotNull(GetKartLog);
        }

        [TestMethod]
        public void GetRankTime()
        {
            List<kart_rank.Models.KartLog> GetKartLog = new List<kart_rank.Models.KartLog>();
            Assert.IsNotNull(GetKartLog);
        }

        [TestMethod]
        public void GetAverageSpeed_ListSpeedNotNull()
        {
            List<decimal> ListSpeed = null;
            Assert.IsNotNull(ListSpeed);
        }

        [TestMethod]
        public void GetAverageSpeed()
        {
            List<decimal> ListSpeed = new List<decimal>();
            Assert.IsNotNull(ListSpeed);
        }

        [TestMethod]
        public void GetTotalTime_TurnsNotNull()
        {
            List<TimeSpan> Turns = null;
            Assert.IsNotNull(Turns);
        }

        [TestMethod]
        public void GetTotalTimeTurns()
        {
            List<TimeSpan> Turns = new List<TimeSpan>();
            Assert.IsNotNull(Turns);
        }

        [TestMethod]
        public void GetRecords_GetRankTimeNotNull()
        {
            List<kart_rank.Models.RankTime> GetRankTime = null;
            Assert.IsNotNull(GetRankTime);
        }

        [TestMethod]
        public void GetRecords_GetRankTime()
        {
            List<kart_rank.Models.RankTime> GetRankTime = new List<kart_rank.Models.RankTime>();
            Assert.IsNotNull(GetRankTime);
        }

        [TestMethod]
        public void GetRankPosition_GetRankTimeNotNull()
        {
            List<kart_rank.Models.RankTime> GetRankTime = null;
            Assert.IsNotNull(GetRankTime);
        }

        [TestMethod]
        public void GetRankPosition_GetRankTime()
        {
            List<kart_rank.Models.RankTime> GetRankTime = new List<kart_rank.Models.RankTime>();
            Assert.IsNotNull(GetRankTime);
        }

        [TestMethod]
        public void GetResultRace_GetRankTimeNotNull()
        {
            List<kart_rank.Models.RankTime> GetRankTime = null;
            Assert.IsNotNull(GetRankTime);
        }

        [TestMethod]
        public void GetResultRace_GetRankTime()
        {
            List<kart_rank.Models.RankTime> GetRankTime = new List<kart_rank.Models.RankTime>();
            Assert.IsNotNull(GetRankTime);
        }


        [TestMethod]
        public void GetResultAfterWinner_GetRecords()
        {
            List<kart_rank.Models.Records> records = new List<kart_rank.Models.Records>();
            Assert.IsNotNull(records);
        }

        [TestMethod]
        public void GetResultAfterWinner_GetRecordsNotNull()
        {
            List<kart_rank.Models.Records> records = null;
            Assert.IsNotNull(records);
        }
    }
}
