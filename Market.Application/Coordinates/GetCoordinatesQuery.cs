using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Market.Application.Coordinates
{
    public class GetCoordinatesQuery : IRequest<IList<List<CoordinatesVM>>>
    {
    }
}
