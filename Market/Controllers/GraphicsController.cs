using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Market.Application.Tracks.Queries.GetTracksByHour;
//using Market.Application.Tracks.Queries.GetTracksByMonth;
using Market.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Market.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphicsController : BaseController
    {
        //[HttpGet("GetMonthly")]
        //public async Task<ActionResult<GetTracksInfoMonthlyVM>> GetMonthly(DateTime DateTime, int ZoneID)
        //{
        //    return Ok(await Mediator.Send(new GetTracksMonthlyQuery { ZoneID = ZoneID, DateTime = DateTime }));
        //}

        //[HttpGet("GetHourly")]
        //public async Task<ActionResult<GetTracksHourlyVM>> GetHourly(DateTime DateTime, int ZoneID)
        //{
        //    return Ok(await Mediator.Send(new GetTracksHourlyQuery(DateTime, ZoneID)));
        //}
    }
}