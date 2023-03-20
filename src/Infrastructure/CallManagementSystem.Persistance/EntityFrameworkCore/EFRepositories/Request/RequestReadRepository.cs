using System;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Contexts;

namespace CallManagementSystem.Persistance.Repositories
{
    public class RequestReadRepository : ReadRepository<Request>, IRequestReadRepository
    {
        public RequestReadRepository(CallManagamentSystemDbContext context) : base(context)
        {
        }
    }
}

