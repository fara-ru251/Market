using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Application.APIVisits.Queries.GetHourly
{
    public class GetHourlyQuery : IRequest<GetHourlyVM>
    {
        public DateTime DateTime { get; private set; }
        public int ZoneID { get; private set; }


        public GetHourlyQuery(DateTime dateTime, int zoneID)
        {
            this.DateTime = dateTime;
            this.ZoneID = zoneID;
        }
    }
}
