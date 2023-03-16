using System;
using CallManagamentSystem.Domain.Entities.Common;

namespace CallManagamentSystem.Domain.Entities
{
	public class User : BaseEntity
	{
		public User()
		{
		}
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string TelNo { get; set; }


		//Relations
		public int AuthorityId { get; set; }
		public virtual Authority Authority { get; set; }
	}
}

