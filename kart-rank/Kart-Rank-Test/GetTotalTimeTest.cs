using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kart_rank.Repository;
using kart_rank.Models;
using Kart_Rank_Test.Repository;

namespace Kart_Rank_Test
{
    [TestClass]
    public class GetTotalTimeTest
    {
        [TestMethod]
        public void Validate_items_Turns()
        {
            // Arrange
            var listInMemoryRepository = KartLogRepository.GetListTurns();

            //Assert
            Assert.IsNotNull(listInMemoryRepository, "Does not exist Turns from kart log");
        }

        [TestMethod]
        public void Add_The_Lap_Times()
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
    }
}
