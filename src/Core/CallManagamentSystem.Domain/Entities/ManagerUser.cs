﻿using System;
namespace CallManagamentSystem.Domain.Entities
{
	public class ManagerUser : User
	{
		public ManagerUser()
		{
		}

		//Relations
		public virtual ICollection<Request> Requests { get; set; }

        
        public int AuthorityId { get; set; }
        public virtual Authority Authority { get; set; }
    }
}

