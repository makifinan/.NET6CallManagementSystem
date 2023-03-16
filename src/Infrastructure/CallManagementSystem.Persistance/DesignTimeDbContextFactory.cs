using System;
using CallManagementSystem.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CallManagementSystem.Persistance
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CallManagamentSystemDbContext>
    {
        public CallManagamentSystemDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<CallManagamentSystemDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=CallMagamentSystemDbContext;");
            return new(dbContextOptionsBuilder.Options);

        }
    }
}

