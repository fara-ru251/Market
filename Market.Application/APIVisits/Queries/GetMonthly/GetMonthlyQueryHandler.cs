﻿using Market.Application.Interfaces;
using Market.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Market.Application.APIVisits.Queries.GetMonthly.GetMonthlyVM;

namespace Market.Application.APIVisits.Queries.GetMonthly
{
    public class GetMonthlyQueryHandler : IRequestHandler<GetMonthlyQuery, GetMonthlyVM>
    {
        private readonly IConDbContext _context;

        public GetMonthlyQueryHandler(IConDbContext context)
        {
            _context = context;
        }

        public Task<GetMonthlyVM> Handle(GetMonthlyQuery request, CancellationToken cancellationToken)
        {
            var result = _context.Visits
                                 .Where(t => t.InTime.HasValue && t.InTime.Value.Month == request.DateTime.Month && t.ZoneId == request.ZoneID)
                                 .GroupBy(g => g.InTime.Value.Day)
                                 .ToList();

            var ans_model = new GetMonthlyVM();

            for (int i = 0; i < result.Count; i++)
            {
                ans_model.All.Add(new VisitGroupingInfo(result[i].Key, result[i].Count()));
                var inner_grouping1 = result[i].GroupBy(g => g.Gender).ToList();
                for (int j = 0; j < inner_grouping1.Count; j++)
                {
                    if (inner_grouping1[j].Key == genders.male)
                    {
                        ans_model.Male.Add(new VisitGroupingInfo(result[i].Key, inner_grouping1[j].Count()));
                    }
                    else
                    {
                        ans_model.Female.Add(new VisitGroupingInfo(result[i].Key, inner_grouping1[j].Count()));
                    }
                }
                var inner_grouping2 = result[i].GroupBy(g => g.Age).ToList();

                for (int j = 0; j < inner_grouping2.Count; j++)
                {
                    switch (inner_grouping2[j].Key)
                    {
                        case ages.teenager:
                            ans_model.Teenager.Add(new VisitGroupingInfo(result[i].Key, inner_grouping2[j].Count()));
                            break;
                        case ages.old:
                            ans_model.Old.Add(new VisitGroupingInfo(result[i].Key, inner_grouping2[j].Count()));
                            break;
                        case ages.young:
                            ans_model.Young.Add(new VisitGroupingInfo(result[i].Key, inner_grouping2[j].Count()));
                            break;
                        case ages.adult:
                            ans_model.Adult.Add(new VisitGroupingInfo(result[i].Key, inner_grouping2[j].Count()));
                            break;
                        default:
                            break;
                    }
                }
            }

            return Task.FromResult(ans_model);
        }
    }
}
