using System;
using CallManagementSystem.Persistance.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Repositories;
using System.Reflection;
using MediatR;
using Microsoft.Extensions.Configuration;

namespace CallManagementSystem.Persistance
{
	public static class PersistanceServiceRegistration
	{

		public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<CallManagamentSystemDbContext>(options => options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=CallMagamentSystemDbContext;"));
			
			services.AddScoped<IStatuReadRepository, StatuReadRepository>();
			services.AddScoped<IStatuWriteRepository, StatuWriteRepository>();

			services.AddScoped<IAuthorityReadRepository, AuthorityReadRepository>();
			services.AddScoped<IAuthorityWriteRepository, AuthorityWriteRepository>();

			services.AddScoped<IDeveloperUserReadRepository, DeveloperUserReadRepository>();
			services.AddScoped<IDeveloperUserWriteRepository, DeveloperUserWriteRepository>();

			services.AddScoped<IManagerUserReadRepository, ManagerUserReadRepository>();
			services.AddScoped<IManagerUserWriteRepository, ManagerUserWriteRepository>();

			services.AddScoped<INotificationReadRepository,NotificationReadRepository>();
			services.AddScoped<INotificationWriteRepository, NotificationWriteRepository>();

            services.AddScoped<INotificationTypeReadRepository, NotificationTypeReadRepository>();
            services.AddScoped<INotificationTypeWriteRepository, NotificationTypeWriteRepository>();

            services.AddScoped<IPriorityReadRepository, PriorityReadRepository>();
            services.AddScoped<IPriorityWriteRepository, PriorityWriteRepository>();

            services.AddScoped<IRequestReadRepository, RequestReadRepository>();
            services.AddScoped<IRequestWriteRepository, RequestWriteRepository>();

            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();

			return services;

        }
	}
}

