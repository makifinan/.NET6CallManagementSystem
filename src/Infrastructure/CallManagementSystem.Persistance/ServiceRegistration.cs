using System;
using CallManagementSystem.Persistance.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Repositories;

namespace CallManagementSystem.Persistance
{
	public static class ServiceRegistration
	{

		public static void ServiceRegistrationAdd(this IServiceCollection service)
		{
			service.AddDbContext<CallManagamentSystemDbContext>(options => options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=CallMagamentSystemDbContext;"));
			
			service.AddScoped<IStatuReadRepository, StatuReadRepository>();
			service.AddScoped<IStatuWriteRepository, StatuWriteRepository>();

			service.AddScoped<IAuthorityReadRepository, AuthorityReadRepository>();
			service.AddScoped<IAuthorityWriteRepository, AuthorityWriteRepository>();

			service.AddScoped<IDeveloperUserReadRepository, DeveloperUserReadRepository>();
			service.AddScoped<IDeveloperUserWriteRepository, DeveloperUserWriteRepository>();

			service.AddScoped<IManagerUserReadRepository, ManagerUserReadRepository>();
			service.AddScoped<IManagerUserWriteRepository, ManagerUserWriteRepository>();

			service.AddScoped<INotificationReadRepository,NotificationReadRepository>();
			service.AddScoped<INotificationWriteRepository, NotificationWriteRepository>();

            service.AddScoped<INotificationTypeReadRepository, NotificationTypeReadRepository>();
            service.AddScoped<INotificationTypeWriteRepository, NotificationTypeWriteRepository>();

            service.AddScoped<IPriorityReadRepository, PriorityReadRepository>();
            service.AddScoped<IPriorityWriteRepository, PriorityWriteRepository>();

            service.AddScoped<IRequestReadRepository, RequestReadRepository>();
            service.AddScoped<IRequestWriteRepository, RequestWriteRepository>();

            service.AddScoped<IUserReadRepository, UserReadRepository>();
            service.AddScoped<IUserWriteRepository, UserWriteRepository>();

        }
	}
}

