using System;
using CallManagamentSystem.Domain.Entities.Common;

namespace CallManagamentSystem.Domain.Entities
{
	public class NotificationType : BaseEntity
	{
		public NotificationType()
		{
		}
		public string NotificationTypeName { get; set; }

		//Relations

		public virtual ICollection<Notification> Notifications { get; set; }
	}
}

