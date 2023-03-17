using System;
using System.Linq.Expressions;
using CallManagamentSystem.Domain.Entities.Common;

namespace CallManagementSystem.Application.Repositories
{
	public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
	{
		IQueryable<T> GetAll();

		IQueryable<T> GetWhere(Expression<Func<T,bool>>method);

		Task<T> GetSingle(Expression<Func<T,bool>> method);

		Task<T> GetByIdAsync(int id);
	}
}

