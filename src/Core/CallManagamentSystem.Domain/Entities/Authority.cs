using System;
using CallManagamentSystem.Domain.Entities.Common;

namespace CallManagamentSystem.Domain.Entities
{
	public class Authority : BaseEntity
	{
		public Authority()
		{
		}
		public string AuthorityName { get; set; }

		//Relations
		public virtual ICollection<User> Users { get; set; }
	}
}

