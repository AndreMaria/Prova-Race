using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace kart_rank.Controllers
{
    public class RaceController : ApiController
    {
        private Service.KartLog service = null;

        public RaceController()
        {
            service = new Service.KartLog();
        }

        [Route("api/Race/GetRecords")]
        [HttpGet]
        public List<Models.Records> GetRecords()
        {
            return service.GetRecords();
        }

        [Route("api/Race/GetRankPosition")]
        [HttpGet]
        public List<Models.RankPosition> GetRankPosition()
        {
            return service.GetRankPosition();
        }

        [Route("api/Race/ResultRace")]
        [HttpGet]
        public List<Models.Race> ResultRace()
        {
            return service.GetResultRace();
        }

        [Route("api/Race/GetRecordByPilotId")]
        [HttpGet]
        public Models.Records GetRecordByPilotId(long pilotId)
        {
            Models.Records result = null;
            List<Models.Records> rank = service.GetRecords();
            if (null != rank && rank.Count > 0)
            {
                result = rank.Where(x => x.PilotId == pilotId).FirstOrDefault();
            }
            return result;
        }

        [Route("api/Race/GetResultAfterWinner")]
        [HttpGet]
        public List<Models.AfterWinner> GetResultAfterWinner()
        {
            return service.GetResultAfterWinner();
        }

        [Route("api/Race/GetResultAfterWinnerByPilotId")]
        [HttpGet]
        public Models.AfterWinner GetResultAfterWinnerByPilotId(long pilotId)
        {
            Models.AfterWinner result = null;
            List < Models.AfterWinner > list = service.GetResultAfterWinner();
            if (null != list)
            {
                result = list.Where(x => x.PilotId == pilotId).FirstOrDefault();
            }
            return result;
        }
    }
}
