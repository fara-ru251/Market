using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.API.Logic.PresentationVisits.Query
{
    public class GetAllVisits :  IRequest<List<VisitsAllTimeSPVM>>
    {
    }
}
