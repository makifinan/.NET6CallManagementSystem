using System;
using CallManagamentSystem.Domain.Entities.Common;

namespace CallManagamentSystem.Domain.Entities
{
	public class Priority : BaseEntity
	{
		public Priority()
		{
		}
		public string PriorityName { get; set; }

		//Relations
		public virtual ICollection<Request> Requests { get; set; }

	}
}

