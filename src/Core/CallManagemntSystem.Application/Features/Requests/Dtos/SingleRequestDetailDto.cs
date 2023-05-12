using System;
namespace CallManagementSystem.Application.Features.Requests.Dtos
{
	public class SingleRequestDetailDto
	{
		public int Id { get; set; }
		public DateTime GeneratedDate { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string EndDate { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PriorityName { get; set; }
		public string StatuName { get; set; }
	}
	
}

