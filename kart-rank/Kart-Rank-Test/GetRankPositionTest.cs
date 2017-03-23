using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kart_rank.Repository;
using kart_rank.Models;
using Kart_Rank_Test.Repository;

namespace Kart_Rank_Test
{
    [TestClass]
    public class GetRankPositionTest
    {
        [TestMethod]
        public void Validate_GetRankTime_ByGetRank()
        {
            // Arrange
            var GetRankTime = KartLogRepository.GetKartLogInMemoryRepository();

            //Assert
            Assert.IsNotNull(GetRankTime, "Does not exist items from kart log");
        }

        [TestMethod]
        public void Not_Validate_GetRankTime_ByGetRank()
        {
            // Arrange
            var GetRankTime = KartLogRepository.NullKartLogInMemoryRepository();

            //Assert
            Assert.IsNotNull(GetRankTime, "Does not exist items from kart log");
        }

        [TestMethod]
        public void Get_Add_The_Lap_Times_ByGetRank()
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
        public void Returns_Data_From_Competitors_ByGetRank()
        {
            //arrange:
            List<string> GetRankTime = KartLogRepository.GetKartLogInMemoryRepository();
            
            
            //act:
            var itens = (from c in GetRankTime
                         group c by new { c } into gp
                         select new { Type = gp, Value = gp.Count() });

            //Assert
            Assert.IsNotNull(itens, "No Return Competitors");
        }

        [TestMethod]
        public void Not_Returns_Data_From_Competitors_ByGetRank()
        {
            //arrange:
            List<string> GetRankTime = KartLogRepository.NullKartLogInMemoryRepository();


            //act:
            var itens = (from c in GetRankTime
                         group c by new { c } into gp
                         select new { Type = gp, Value = gp.Count() });

            //Assert
            Assert.IsNotNull(itens, "No Return Competitors");
        }
    }
}
