using System;
using CallManagamentSystem.Domain.Entities.Common;

namespace CallManagamentSystem.Domain.Entities
{
	public class Request : BaseEntity
	{
		
		public string Description { get; set; }
		public string EndDate { get; set; }
		public string Title { get; set; }

		//Relations
		public int ManagerUserId { get; set; }
		public virtual ManagerUser ManagerUser { get; set; }

		public int DeveloperUserId { get; set; }
		public virtual DeveloperUser DeveloperUser { get; set; }

		public int PriorityId { get; set; }
		public virtual Priority Priority { get; set; }

		public int StatuId { get; set; }
		public virtual Statu Statu { get; set; }


	}
}

