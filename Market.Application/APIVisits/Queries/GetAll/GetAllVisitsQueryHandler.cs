using Market.Application.Interfaces;
using MediatR;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Market.Application.APIVisits.Queries.GetAll
{
    public class GetAllVisitsQueryHandler : IRequestHandler<GetAllVisitsQuery, List<VisitsAllTimeVM>>
    {
        private readonly IConDbContext _context;
        //private readonly IMapper _mapper;

        //public GetAllVisitsQueryHandler(IConDbContext context, IMapper mapper)
        //{
        //    _context = context;
        //    _mapper = mapper;
        //}
        public GetAllVisitsQueryHandler(IConDbContext context)
        {
            _context = context;
        }



        public Task<List<VisitsAllTimeVM>> Handle(GetAllVisitsQuery request, CancellationToken cancellationToken)
        {
            #region Code Variant
            var result = _context.Visits
                                 .GroupBy(g => g.ZoneId,
                                     (Key, Values) => new VisitsAllTimeVM
                                     {
                                         ZoneID = Key,
                                         Total = Values.Count(),
                                         GenderInfo = Values.GroupBy(g => g.Gender,
                                             (m, values) => new VisitByCharacteristics
                                             {
                                                 Type = m.ToString(),
                                                 Total = values.Count(),
                                             }),
                                         AgeInfo = Values.GroupBy(g => g.Age,
                                             (k, values) => new VisitByCharacteristics
                                             {
                                                 Type = k.ToString(),
                                                 Total = values.Count()
                                             })
                                     })
                                 .ToListAsync();
            #endregion
            //var ans = _context.Query<List<VisitAllTimeDTO>>().FromSql("SELECT * FROM visits");

            return result;
        }
    }
}
