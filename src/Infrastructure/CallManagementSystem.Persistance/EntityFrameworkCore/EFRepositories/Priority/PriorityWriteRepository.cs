using System;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Contexts;
using CallManagementSystem.Persistance.Repository;

namespace CallManagementSystem.Persistance.Repositories
{
    public class PriorityWriteRepository : WriteRepository<Priority>, IPriorityWriteRepository
    {
        public PriorityWriteRepository(CallManagamentSystemDbContext context) : base(context)
        {
        }
    }
}

