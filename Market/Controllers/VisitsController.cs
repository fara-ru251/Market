using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Market.API.Logic.PresentationVisits.Query;
using Market.Application.APIVisits.Queries.GetAll;
using Market.Application.APIVisits.Queries.GetHourly;
using Market.Application.APIVisits.Queries.GetMonthly;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Market.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<GetMonthlyVM>> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllVisitsQuery()));
        }

        [HttpGet("GetAllSP")]
        public async Task<ActionResult<GetMonthlyVM>> GetAllSP()
        {
            return Ok(await Mediator.Send(new GetAllVisits()));
        }

        [HttpGet("GetMonthly")]
        public async Task<ActionResult<GetMonthlyVM>> GetMonthly(DateTime DateTime, int ZoneID)
        {
            return Ok(await Mediator.Send(new GetMonthlyQuery(DateTime, ZoneID)));
        }

        [HttpGet("GetHourly")]
        public async Task<ActionResult<GetHourlyVM>> GetHourly(DateTime DateTime, int ZoneID)
        {
            return Ok(await Mediator.Send(new GetHourlyQuery(DateTime, ZoneID)));
        }
    }
}