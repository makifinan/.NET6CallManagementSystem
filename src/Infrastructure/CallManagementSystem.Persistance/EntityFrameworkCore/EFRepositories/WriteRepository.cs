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
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            var response = entityEntry.State == EntityState.Added;
            _context.SaveChangesAsync();
            return response;
        }

        public async Task<bool> AddRangeAsync(List<T> entities)
        {
            await Table.AddRangeAsync(entities);
            _context.SaveChanges();
            return true;
        }

        public bool Remove(T entity)
        {
            EntityEntry<T> entityEntry= Table.Remove(entity);
            var response = entityEntry.State == EntityState.Deleted;
            _context.SaveChanges();
            return response;

        }

        public async Task<bool> Update(T entity)
        {
            EntityEntry<T> entityEntry = Table.Update(entity);
            var response = entityEntry.State == EntityState.Modified;
            await _context.SaveChangesAsync();
            return response;
        }

        
    }
}

