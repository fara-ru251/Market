using AutoMapper;
using Market.Application.Interfaces.Mapping;
//using Market.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Application.ObsoleteCameras.Queries.GetCamera
{
    //public class CameraVM : IHaveCustomMapping
    //{
    //    public int CameraID { get; set; }

    //    public string CameraName { get; set; }



    //    public void CreateMappings(Profile configuration)
    //    {
    //        configuration.CreateMap<Camera, CameraVM>()
    //                     //.ForMember(pDTO => pDTO.CameraName, opt => opt.MapFrom<PermissionsResolver>());
    //                     .ForMember(pDTO => pDTO.CameraName, opt => opt.MapFrom(p => p.CameraName != null ? p.CameraName : string.Empty));
    //    }

    //    class PermissionsResolver : IValueResolver<Camera, CameraVM, bool>
    //    {
    //        // TODO: inject your services and helper here
    //        public PermissionsResolver()
    //        {

    //        }

    //        public bool Resolve(Camera source, CameraVM destination, bool destMember, ResolutionContext context)
    //        {
    //            return false;
    //        }


    //    }
    //}
}
