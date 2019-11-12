using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Market.Application.Coordinates;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Market.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoordinatesController : BaseController
    {

        [HttpGet]
        public async Task<ActionResult<IList<List<CoordinatesVM>>>> GetAll()
        {
            return Ok(await Mediator.Send(new GetCoordinatesQuery()));
        }
    }
}