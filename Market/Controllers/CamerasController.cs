using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Market.Application.Cameras.Queries.GetAllCameras;
//using Market.Application.Cameras.Queries.GetCamera;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Market.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CamerasController : BaseController
    {
        //obsolete
        //[HttpGet]
        //public async Task<ActionResult<CamerasListViewModel>> GetAll()
        //{
        //    return Ok(await Mediator.Send(new GetAllCamerasQuery()));
        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult<CameraVM>> Get(int id)
        //{
        //    return Ok(await Mediator.Send(new GetCameraQuery { Id = id }));
        //}
    }
}