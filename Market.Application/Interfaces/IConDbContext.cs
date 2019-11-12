using Market.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Market.Application.Interfaces
{
    public interface IConDbContext 
    {
        DbSet<CameraZones> CameraZones { get; set; }
        DbSet<Cameras> Cameras { get; set; }
        DbSet<OperatorService> OperatorService { get; set; }
        DbSet<OperatorWork> OperatorWork { get; set; }
        DbSet<Operators> Operators { get; set; }
        DbSet<Visits> Visits { get; set; }
        DbSet<Zones> Zones { get; set; }

        //TODO FROM INTERFACE
        //DatabaseFacade Database { get; set; }

        DbQuery<TQuery> Query<TQuery>() where TQuery : class;

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
