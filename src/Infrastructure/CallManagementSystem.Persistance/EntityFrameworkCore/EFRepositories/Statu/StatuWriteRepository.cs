using System;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Contexts;
using CallManagementSystem.Persistance.Repository;

namespace CallManagementSystem.Persistance.Repositories
{
    public class StatuWriteRepository : WriteRepository<Statu>, IStatuWriteRepository
    {
        public StatuWriteRepository(CallManagamentSystemDbContext context) : base(context)
        {
        }
    }
}

