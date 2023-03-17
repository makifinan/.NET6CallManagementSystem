using System;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Contexts;

namespace CallManagementSystem.Persistance.Repositories
{
    public class AuthorityReadRepository : ReadRepository<Authority>, IAuthorityReadRepository
    {
        public AuthorityReadRepository(CallManagamentSystemDbContext context) : base(context)
        {
        }
    }
}

