using System;
using CallManagamentSystem.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace CallManagementSystem.Application.Repositories
{
	public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
	{
		Task<bool> AddAsync(T entity);
		Task<bool> AddRangeAsync(List<T> entities);
		bool Remove(T entity);
		bool Update(T entity);
		Task<int> SaveAsync();
            


    }
}

