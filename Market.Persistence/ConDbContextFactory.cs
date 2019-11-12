using Market.Persistence.Infrastructure;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Persistence
{
    public class ConDbContextFactory : DesignTimeDbContextFactoryBase<ConDbContext>
    {
        protected override ConDbContext CreateNewInstance(DbContextOptions<ConDbContext> options)
        {
            return new ConDbContext(options);
        }
    }
}
