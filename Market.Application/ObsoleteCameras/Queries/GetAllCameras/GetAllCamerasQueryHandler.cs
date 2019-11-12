using AutoMapper;
using Market.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Market.Application.ObsoleteCameras.Queries.GetAllCameras
{
    //class GetAllCamerasQueryHandler : IRequestHandler<GetAllCamerasQuery, CamerasListViewModel>
    //{
    //    private readonly IMarketDbContext _context;
    //    private readonly IMapper _mapper;

    //    public GetAllCamerasQueryHandler(IMarketDbContext context, IMapper mapper)
    //    {
    //        _context = context;
    //        _mapper = mapper;
    //    }

    //    public async Task<CamerasListViewModel> Handle(GetAllCamerasQuery request, CancellationToken cancellationToken)
    //    {
    //        // TODO: Set view model state based on user permissions.
    //        var cameras = await _context.Cameras.OrderBy(p => p.CameraName).ToListAsync(cancellationToken);

    //        var model = new CamerasListViewModel
    //        {
    //            Cameras = _mapper.Map<IEnumerable<CameraDTO>>(cameras),
    //        };

    //        return model;
    //    }
    //}
}
