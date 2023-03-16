using System;
using CallManagementSystem.Persistance.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace CallManagementSystem.Persistance
{
	public static class ServiceRegistration
	{

		public static void ServiceRegistrationAdd(this IServiceCollection service)
		{
			service.AddDbContext<CallManagamentSystemDbContext>(options => options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=CallMagamentSystemDbContext;"));
		}
	}
}

