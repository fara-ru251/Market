using AutoMapper;
using Market.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace Market.Application.ObsoleteTracks.Queries.GetTracksByMonth
{
    //public class GetTracksMonthlyQueryHandler : MediatR.IRequestHandler<GetTracksMonthlyQuery, GetTracksInfoMonthlyVM>
    //{
    //    private readonly IMarketDbContext _context;
    //    private readonly IMapper _mapper;

    //    public GetTracksMonthlyQueryHandler(IMarketDbContext context, IMapper mapper)
    //    {
    //        _context = context;
    //        _mapper = mapper;
    //    }

    //    public Task<GetTracksInfoMonthlyVM> Handle(GetTracksMonthlyQuery request, CancellationToken cancellationToken)
    //    {

    //        var result = _context.Tracks
    //                             .Where(t => t.Date.HasValue && t.Date.Value.Month == request.DateTime.Month /*&& t.ZoneId == request.ZoneID*/)
    //                             .GroupBy(
    //                                    g =>  g.Date.Value.Day
    //                                    //(Key, Values) => new GetTracksMonthlyVM
    //                                    //{
    //                                    //    Day = Key,
    //                                    //    Total = Values.Count(),
    //                                    //    GenderInfo = Values.GroupBy(g => g.Gender,
    //                                    //    (m, values) => new GenderInfo
    //                                    //    {
    //                                    //        Day = Key,
    //                                    //        Gender = m,
    //                                    //        Total = values.Count(),
    //                                    //    }),
    //                                    //    AgeInfo = Values.GroupBy(g => g.Age,
    //                                    //    (k, values) => new AgeInfo
    //                                    //    {
    //                                    //        Day = Key,
    //                                    //        Age = k,
    //                                    //        Total = values.Count()
    //                                    //    })
    //                                    //}
    //                             ).ToList();

    //        var ans_model = new GetTracksInfoMonthlyVM();

    //        for (int i = 0; i < result.Count; i++)
    //        {
    //            ans_model.All.Add(new TrackGroupingInfo(result[i].Key, result[i].Count()));
    //            var inner_grouping1 = result[i].GroupBy(g => g.Gender).ToList();
    //            for (int j = 0; j < inner_grouping1.Count; j++)
    //            {
    //                if (inner_grouping1[j].Key == "male")
    //                {
    //                    ans_model.Male.Add(new TrackGroupingInfo(result[i].Key, inner_grouping1[j].Count()));
    //                }
    //                else
    //                {
    //                    ans_model.Female.Add(new TrackGroupingInfo(result[i].Key, inner_grouping1[j].Count()));
    //                }
    //            }
    //            var inner_grouping2 = result[i].GroupBy(g => g.Age).ToList();

    //            for (int j = 0; j < inner_grouping2.Count; j++)
    //            {
    //                switch (inner_grouping2[j].Key)
    //                {
    //                    case "teenager":
    //                        ans_model.Teenager.Add(new TrackGroupingInfo(result[i].Key, inner_grouping2[j].Count()));
    //                        break;
    //                    case "old":
    //                        ans_model.Old.Add(new TrackGroupingInfo(result[i].Key, inner_grouping2[j].Count()));
    //                        break;
    //                    case "child":
    //                        ans_model.Child.Add(new TrackGroupingInfo(result[i].Key, inner_grouping2[j].Count()));
    //                        break;
    //                    case "adult":
    //                        ans_model.Adult.Add(new TrackGroupingInfo(result[i].Key, inner_grouping2[j].Count()));
    //                        break;
    //                    default:
    //                        break;
    //                }
    //            }
    //        }





    //        return Task.FromResult(ans_model);
    //    }
    //}
}
