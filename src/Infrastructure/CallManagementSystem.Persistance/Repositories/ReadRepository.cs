using System;
using System.Linq.Expressions;
using CallManagamentSystem.Domain.Entities.Common;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CallManagementSystem.Persistance
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly CallManagamentSystemDbContext _context;

        public ReadRepository(CallManagamentSystemDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
        {
            return Table;
        }
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        {
            return Table.Where(method);
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return  await Table.FindAsync(id);
        }

        public async Task<T> GetSingle(Expression<Func<T, bool>> method)
        {
            return await Table.FirstOrDefaultAsync(method);
        }

        
    }
}

