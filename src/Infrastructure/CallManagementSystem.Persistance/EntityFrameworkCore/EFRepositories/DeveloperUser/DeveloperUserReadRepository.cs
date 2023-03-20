using System;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Contexts;

namespace CallManagementSystem.Persistance.Repositories
{
    public class DeveloperUserReadRepository : ReadRepository<DeveloperUser>, IDeveloperUserReadRepository
    {
        public DeveloperUserReadRepository(CallManagamentSystemDbContext context) : base(context)
        {
        }
    }
}

