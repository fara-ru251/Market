using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Application.APIVisits.Queries.GetAll
{
    public class GetAllVisitsQuery : IRequest<List<VisitsAllTimeVM>>
    {
        //nothing
    }
}
