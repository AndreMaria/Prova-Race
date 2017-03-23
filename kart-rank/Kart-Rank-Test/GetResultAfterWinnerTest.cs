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
    public class GetResultAfterWinnerTest
    {
        [TestMethod]
        public void Validate_GetRecords_ByGetResultAfterWinner()
        {
            // Arrange
            var GetRecords = KartLogRepository.GetKartLogInMemoryRepository();

            //Assert
            Assert.IsNotNull(GetRecords, "Does not exist items from kart log");
        }

        [TestMethod]
        public void Not_Validate_GetRecords_ByGetResultAfterWinner()
        {
            // Arrange
            var GetRecords = KartLogRepository.NullKartLogInMemoryRepository();

            //Assert
            Assert.IsNotNull(GetRecords, "Does not exist items from kart log");
        }

        [TestMethod]
        public void Get_First_Or_Default_ByGetResultAfterWinner()
        {
            //arrange:
            var itens = KartLogRepository.GetKartLogInMemoryRepository();

            //act:
            var result = itens.FirstOrDefault();

            //Assert
            Assert.IsNotNull(result, "Not Exist");
        }

        [TestMethod]
        public void Get_First_Or_Default_Not_Exist_ByGetResultAfterWinner()
        {
            //arrange:
            var itens = KartLogRepository.NullKartLogInMemoryRepository();

            //act:
            var result = itens.FirstOrDefault();

            //Assert
            Assert.IsNotNull(result, "Not Exist");
        }

        [TestMethod]
        public void Returns_Data_From_Competitors_ByGetResultAfterWinner()
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
        public void Not_Returns_Data_From_Competitors_ByGetResultAfterWinner()
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
