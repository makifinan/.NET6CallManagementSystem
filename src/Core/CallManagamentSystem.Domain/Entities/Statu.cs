using System;
using CallManagamentSystem.Domain.Entities.Common;

namespace CallManagamentSystem.Domain.Entities
{
	public class Statu : BaseEntity
	{
		public Statu()
		{
		}

		public string StatuName { get; set; }

		//relations
		public ICollection<Request> Requests { get; set; }

	}
}

