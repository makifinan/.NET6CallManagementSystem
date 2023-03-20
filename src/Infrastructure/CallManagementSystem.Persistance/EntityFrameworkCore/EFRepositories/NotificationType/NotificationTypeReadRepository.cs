using System;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Contexts;

namespace CallManagementSystem.Persistance.Repositories
{
    public class NotificationTypeReadRepository : ReadRepository<NotificationType>, INotificationTypeReadRepository
    {
        public NotificationTypeReadRepository(CallManagamentSystemDbContext context) : base(context)
        {
        }
    }
}

