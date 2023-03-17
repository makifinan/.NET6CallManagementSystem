using System;
using CallManagamentSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CallManagementSystem.Persistance.Contexts
{
	public class CallManagamentSystemDbContext : DbContext
	{
	

        public CallManagamentSystemDbContext(DbContextOptions options) : base(options)
        {
        }

		//public DbSet<User> Users { get; set; }
		public DbSet<Notification> Notifications { get; set; }
		public DbSet<NotificationType> NotificationTypes { get; set; }
		public DbSet<Request> Requests { get; set; }
		public DbSet<Statu> Status { get; set; }
		public DbSet<DeveloperUser> DeveloperUsers { get; set; }
		public DbSet<ManagerUser> ManagerUsers { get; set; }
	}
}

