using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kart_rank.Repository;
using kart_rank.Models;
using Kart_Rank_Test.Repository;

namespace Kart_Rank_Test
{
    [TestClass]
    public class GetRankTimeTest
    {
        [TestMethod]
        public void Validate_Retrieves_All_items_From_Kart_Log()
        {
            // Arrange
            var listInMemoryRepository = KartLogRepository.GetKartLogInMemoryRepository();

            //Assert
            Assert.IsNotNull(listInMemoryRepository, "Does not exist items from kart log");
        }

        [TestMethod]
        public void Not_Create_Rank_Time()
        {
            //arrange:
            var listInMemoryRepository = KartLogRepository.NullKartLogInMemoryRepository();

            //Assert
            Assert.IsNotNull(listInMemoryRepository, "Does not exist items from kart log");
        }
    }
}
