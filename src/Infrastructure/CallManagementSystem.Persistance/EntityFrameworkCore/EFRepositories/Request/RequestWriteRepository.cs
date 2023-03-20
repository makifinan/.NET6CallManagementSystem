using System;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Contexts;
using CallManagementSystem.Persistance.Repository;

namespace CallManagementSystem.Persistance.Repositories
{
    public class RequestWriteRepository : WriteRepository<Request>, IRequestWriteRepository
    {
        public RequestWriteRepository(CallManagamentSystemDbContext context) : base(context)
        {
        }
    }
}

