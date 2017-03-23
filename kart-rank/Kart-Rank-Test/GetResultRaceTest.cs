using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kart_rank.Repository;
using kart_rank.Models;
using Kart_Rank_Test.Repository;

namespace Kart_Rank_Test
{
    [TestClass]
    public class GetResultRaceTest
    {
        [TestMethod]
        public void Validate_GetRankTime_ByGetResultRace()
        {
            // Arrange
            var GetRankTime = KartLogRepository.GetKartLogInMemoryRepository();

            //Assert
            Assert.IsNotNull(GetRankTime, "Does not exist items from kart log");
        }

        [TestMethod]
        public void Not_Validate_GetRankTime_ByGetResultRace()
        {
            // Arrange
            var GetRankTime = KartLogRepository.NullKartLogInMemoryRepository();

            //Assert
            Assert.IsNotNull(GetRankTime, "Does not exist items from kart log");
        }

        [TestMethod]
        public void Get_Add_The_Lap_Times_ByGetResultRace()
        {
            //arrange:
            var listInMemoryRepository = KartLogRepository.GetListTurns();

            //act:
            var result = listInMemoryRepository[0] + listInMemoryRepository[1];

            //Assert
            Assert.IsNotNull(result, "Could not add");
            Assert.IsTrue(result > listInMemoryRepository[0]);
            Assert.IsTrue(result > listInMemoryRepository[1]);
        }

        [TestMethod]
        public void Returns_Data_From_Competitors_ByGetResultRace()
        {
            //arrange:
            var GetRankTime = KartLogRepository.GetKartLogInMemoryRepository();
            //act:
            var item = (from c in GetRankTime
                        group c by new { c } into gsc
                        select new { type = gsc.Key.c, count = gsc.Count() }
                    );

            //Assert
            Assert.IsNotNull(item, "Could not add");
        }

        [TestMethod]
        public void Not_Returns_Data_From_Competitors_ByGetResultRace()
        {
            //arrange:
            var GetRankTime = KartLogRepository.NullKartLogInMemoryRepository();
            //act:
            var item = (from c in GetRankTime
                        group c by new { c } into gsc
                        select new { type = gsc.Key.c, count = gsc.Count() }
                    );

            //Assert
            Assert.IsNotNull(item, "No Return Competitors");
        }
    }
}
