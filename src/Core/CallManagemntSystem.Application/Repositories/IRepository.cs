using System;
using CallManagamentSystem.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace CallManagementSystem.Application.Repositories
{
	public interface IRepository<T> where T : BaseEntity
	{
		DbSet<T> Table { get; }
	}
}

