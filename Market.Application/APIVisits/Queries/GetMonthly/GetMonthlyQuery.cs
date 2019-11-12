﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Application.APIVisits.Queries.GetMonthly
{
    public class GetMonthlyQuery : IRequest<GetMonthlyVM>
    {
        public DateTime DateTime { get; private set; }
        public int ZoneID { get; private set; }


        public GetMonthlyQuery(DateTime dateTime, int zoneID)
        {
            this.DateTime = dateTime;
            this.ZoneID = zoneID;
        }
    }
}
