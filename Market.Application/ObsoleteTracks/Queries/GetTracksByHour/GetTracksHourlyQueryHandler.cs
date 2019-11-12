using AutoMapper;
using Market.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using static Market.Application.Tracks.Queries.GetTracksByHour.GetTracksHourlyVM;

namespace Market.Application.ObsoleteTracks.Queries.GetTracksByHour
{
    //public class GetTracksHourlyQueryHandler : MediatR.IRequestHandler<GetTracksHourlyQuery, GetTracksHourlyVM>
    //{
    //    private readonly IMarketDbContext _context;
    //    private readonly IMapper _mapper;

    //    public GetTracksHourlyQueryHandler(IMarketDbContext context, IMapper mapper)
    //    {
    //        _context = context;
    //        _mapper = mapper;
    //    }

    //    public Task<GetTracksHourlyVM> Handle(GetTracksHourlyQuery request, CancellationToken cancellationToken)
    //    {
    //        var result = _context.Tracks
    //                             .Where(t => t.Date.HasValue && t.Date.Value.Day == request.DateTime.Day /*&& t.ZoneId == request.ZoneID*/)
    //                             .GroupBy(g => g.InTime.Value.Hours)
    //                             .ToList();

    //        var ans_model = new GetTracksHourlyVM();

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
