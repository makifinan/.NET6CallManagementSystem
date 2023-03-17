using System;
using CallManagamentSystem.Domain.Entities.Common;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CallManagementSystem.Persistance.Repository
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly CallManagamentSystemDbContext _context;

        public WriteRepository(CallManagamentSystemDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry =await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> entities)
        {
            await Table.AddRangeAsync(entities);
            
            return true;
        }

        public bool Remove(T entity)
        {
            EntityEntry<T> entityEntry= Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;

        }

        public bool Update(T entity)
        {
            EntityEntry<T> entityEntry = Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }
        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();
    }
}

