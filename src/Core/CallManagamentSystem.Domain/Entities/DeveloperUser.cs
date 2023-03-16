using System;
namespace CallManagamentSystem.Domain.Entities
{
	public class DeveloperUser : User
	{
		public DeveloperUser()
		{
		}
		public virtual ICollection<Request> Requests { get; set; }

	}
}

