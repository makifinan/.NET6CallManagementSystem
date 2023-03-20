using System;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Contexts;

namespace CallManagementSystem.Persistance.Repositories
{
    public class StatuReadRepository : ReadRepository<Statu>, IStatuReadRepository
    {
        public StatuReadRepository(CallManagamentSystemDbContext context) : base(context)
        {
        }
    }
}

