using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Application.Interfaces.Mapping
{
    public interface IMapFrom<TEntity>
    {
        //in C# 8.0 only
        void Mapping(Profile profile); //=> profile.CreateMap(typeof(TEntity), GetType());
    }
}
