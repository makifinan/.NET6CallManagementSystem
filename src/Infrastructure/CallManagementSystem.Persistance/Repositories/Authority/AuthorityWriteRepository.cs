using System;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Contexts;
using CallManagementSystem.Persistance.Repository;

namespace CallManagementSystem.Persistance.Repositories
{
    public class AuthorityWriteRepository : WriteRepository<Authority>, IAuthorityWriteRepository
    {
        public AuthorityWriteRepository(CallManagamentSystemDbContext context) : base(context)
        {
        }
    }
}

