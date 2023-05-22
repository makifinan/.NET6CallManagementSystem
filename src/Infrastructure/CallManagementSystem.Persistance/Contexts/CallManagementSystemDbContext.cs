using System;
using CallManagamentSystem.Domain.Entities;
using CallManagamentSystem.Domain.Entities.Common;
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
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Authority> Authorities { get; set; }


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //ChangeTracker : Entityler üzerinden yapılan değişiklerin ya da yeni eklenen verinin yakalanmasını sağlayan propertydir. Update operasyonlarında Track edilen verileri yakalayıp elde etmemizi sağlar.

            var addedEntities = ChangeTracker
        .Entries<BaseEntity>()
        .Where(e => e.State == EntityState.Added);

            foreach (var entityEntry in addedEntities)
            {
                entityEntry.Property("GeneratedDate").CurrentValue = DateTime.UtcNow.AddHours(3);
            }

            var modifiedEntities = ChangeTracker
                .Entries<BaseEntity>()
                .Where(e => e.State == EntityState.Modified);

            foreach (var entityEntry in modifiedEntities)
            {
                entityEntry.Property("GeneratedDate").IsModified = false; // GeneratedDate güncellenmeyecek
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}

