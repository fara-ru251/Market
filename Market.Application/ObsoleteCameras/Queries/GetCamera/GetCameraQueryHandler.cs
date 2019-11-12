using AutoMapper;
using Market.Application.Exceptions;
using Market.Application.Interfaces;
//using Market.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Market.Application.ObsoleteCameras.Queries.GetCamera
{
    //public class GetCameraQueryHandler : MediatR.IRequestHandler<GetCameraQuery, CameraVM>
    //{
    //    private readonly IMarketDbContext _context;
    //    private readonly IMapper _mapper;

    //    public GetCameraQueryHandler(IMarketDbContext context, IMapper mapper)
    //    {
    //        _context = context;
    //        _mapper = mapper;
    //    }

    //    public async Task<CameraVM> Handle(GetCameraQuery request, CancellationToken cancellationToken)
    //    {
    //        var camera = _mapper.Map<CameraVM>(await _context
    //            .Cameras.Where(p => p.CameraId == request.Id)
    //            .SingleOrDefaultAsync(cancellationToken));

    //        if (camera == null)
    //        {
    //            throw new NotFoundException(nameof(Camera), request.Id);
    //        }


    //        //WAIT for Jason Taylor updates
    //        // TODO: Set view model state based on user permissions.
    //        //camera.EditEnabled = true;

    //        return camera;
    //    }
    //}
}
