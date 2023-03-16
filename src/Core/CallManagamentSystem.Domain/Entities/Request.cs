using System;
using CallManagamentSystem.Domain.Entities.Common;

namespace CallManagamentSystem.Domain.Entities
{
	public class Request : BaseEntity
	{
		public Request()
		{
		}
		public string Description { get; set; }
		public DateTime EndDate { get; set; }

		//Relations
		public int ManagerUserId { get; set; }
		public virtual ManagerUser ManagerUserT { get; set; }

		public int DeveloperUserId { get; set; }
		public virtual DeveloperUser DeveloperUserT { get; set; }

		public int PriorityId { get; set; }
		public virtual Priority PriorityT { get; set; }

		public int StatuId { get; set; }
		public virtual Statu StatuT { get; set; }


	}
}

