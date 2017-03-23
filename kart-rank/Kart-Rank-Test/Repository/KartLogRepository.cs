using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kart_Rank_Test.Repository
{
    public class KartLogRepository
    {
        public static List<String> GetKartLogInMemoryRepository()
        {
            List<String> MemoryRepository = new List<String>();
            String[] listKartLog1 =
            {
                "23:49:10.858",
                "033",
                "R.BARRICHELLO",
                "1",
                "1:04.352",
                "43,243"
            };
            MemoryRepository.AddRange(listKartLog1);
            String[] listKartLog2 =
            {
                "23:49:11.075",
                "002",
                "K.RAIKKONEN",
                "1",
                "1:04.108",
                "43,408"
            };
            MemoryRepository.AddRange(listKartLog2);

            return MemoryRepository;
        }

        public static List<String> NullKartLogInMemoryRepository()
        {
            List<String> MemoryRepository = null;
            return MemoryRepository;
        }

        public static List<Decimal> GetListSpeed()
        {
            List<Decimal> itens = new List<Decimal>();
            itens.Add(Convert.ToDecimal(43.243));
            itens.Add(Convert.ToDecimal(43.408));

            return itens;
        }

        public static List<TimeSpan> GetListTurns()
        {
            List<TimeSpan> itens = new List<TimeSpan>();
            itens.Add(new TimeSpan(00, 1, 2));
            itens.Add(new TimeSpan(00, 1, 2));
            return itens;
        }
    }
}
