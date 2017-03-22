using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kart_rank.Repository
{
    public class KartLog : Repository
    {
        public static ReaderData<Models.KartLog> objDelegateKartLog = delegate (String line)
        {
            char[] i = new char[1];
            i[0] = '\t';
            List<String> itens = GetSplitItem(line, i);

            var listItem = (from item in line.Split(i, StringSplitOptions.RemoveEmptyEntries)
                            where !String.IsNullOrEmpty(item.Trim())
                            select item).ToList();

            Models.KartLog kartLog = null;

            if (listItem.Count > 4)
            {
                
                TimeSpan hour;
                long Id = 0 ;
                String PilotName;
                int NTurn;
                TimeSpan Time;
                Decimal AverageSpeed;

                TimeSpan.TryParse(listItem[0], out hour);

                char[] codigo = new char[1];
                codigo[0] = '–';
                List<String> Pilot = GetSplitItem(listItem[1].Trim(), codigo);

                if(null != Pilot)
                {
                    kartLog = new Models.KartLog();
                    long.TryParse(Pilot[0], out Id);
                    PilotName = Pilot[1];
                    int.TryParse(listItem[2], out NTurn);
                    TimeSpan.TryParse(String.Format("00:0{0}", listItem[3]), out Time);
                    Decimal.TryParse(listItem[4], out AverageSpeed);

                    kartLog.Hour = hour;
                    kartLog.PilotId = Id;
                    kartLog.PilotName = PilotName;
                    kartLog.NTurn = NTurn;
                    kartLog.Time = Time;
                    kartLog.AverageSpeed = AverageSpeed;
                }
            }
            return kartLog;
        };

        public static List<String> GetSplitItem(String line, char[] i)
        {
            return line.Split(i, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public List<Models.KartLog> GetKartLog()
        {
            return this.ReaderFile<Models.KartLog>(objDelegateKartLog);
        }
    }
}