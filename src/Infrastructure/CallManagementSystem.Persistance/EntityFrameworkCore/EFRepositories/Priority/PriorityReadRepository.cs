using System;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Contexts;

namespace CallManagementSystem.Persistance.Repositories
{
    public class PriorityReadRepository : ReadRepository<Priority>, IPriorityReadRepository
    {
        public PriorityReadRepository(CallManagamentSystemDbContext context) : base(context)
        {
        }
    }
}

