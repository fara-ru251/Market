//using Market.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Market.Application.Interfaces
{
    public interface IObsoleteMarketDbContext
    {
        //DbSet<Camera> Cameras { get; set; }

        //DbSet<Track> Tracks { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
