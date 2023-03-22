using System;
namespace CallManagamentSystem.Domain.Entities.Common
{
	public class BaseEntity
	{
       


        public int Id { get; set; }
		public DateTime GeneratedDate { get; set ; }
        public DateTime UpdatedDate { get; set; }

        

    }
}

