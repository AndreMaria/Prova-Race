using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kart_rank.Repository;
using kart_rank.Models;

namespace Kart_Rank_Test
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void GetKartLog()
        {
            kart_rank.Models.KartLog objDelegateKartLog = new kart_rank.Models.KartLog();
            Assert.IsNotNull(objDelegateKartLog);
        }

        [TestMethod]
        public void GetKartLog_DelegateKartLogNotNull()
        {
            kart_rank.Models.KartLog objDelegateKartLog = null;
            Assert.IsNotNull(objDelegateKartLog);
        }

        [TestMethod]
        public void objDelegateKartLogLineEmpty()
        {
            String line = "";
            Assert.IsFalse(String.IsNullOrEmpty(line));
        }

        [TestMethod]
        public void objDelegateKartLog()
        {
            String line = "23:49:08.277 	  038 – F.MASSA		  	  1		1:02.852 			44,275";
            Assert.IsFalse(String.IsNullOrEmpty(line));
        }

        [TestMethod]
        public void GetSplitItem()
        {
            String line = "23:49:08.277 	  038 – F.MASSA		  	  1		1:02.852 			44,275";
            char[] i = new char[1];
            Assert.IsFalse(String.IsNullOrEmpty(line));
            Assert.IsNotNull(i);
        }

        [TestMethod]
        public void GetSplitItemLineEmpty()
        {
            String line = "";

            Assert.IsTrue(line == "23:49:08.277 	  038 – F.MASSA		  	  1		1:02.852 			44,275");
            char[] i = new char[1];
            Assert.IsNotNull(i);
        }

        [TestMethod]
        public void GetSplitItemLineEmptyCharNull()
        {
            String line = "";
            char[] i = null;
            Assert.IsTrue(line == "23:49:08.277 	  038 – F.MASSA		  	  1		1:02.852 			44,275");
            Assert.IsNotNull(i);
        }

        [TestMethod]
        public void GetSplitItemLineCharNull()
        {
            String line = "23:49:08.277 	  038 – F.MASSA		  	  1		1:02.852 			44,275";
            char[] i = null;
            Assert.IsTrue(line == "23:49:08.277 	  038 – F.MASSA		  	  1		1:02.852 			44,275");
            Assert.IsNotNull(i);
        }
    }
}
