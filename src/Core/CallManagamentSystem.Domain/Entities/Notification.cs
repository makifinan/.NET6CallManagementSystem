using System;
using CallManagamentSystem.Domain.Entities.Common;

namespace CallManagamentSystem.Domain.Entities
{
	public class Notification : BaseEntity
	{
		public Notification()
		{
		}

		public string Description { get; set; }

		//Relations

		public int NotificationTypeId { get; set; }
		public virtual NotificationType NotificationType { get; set; }

	}
}

