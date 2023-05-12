using System;
namespace CallManagementSystem.Application.Features.Requests.Dtos
{
	public class CreatedRequestDto
	{
        public string Description { get; set; }
        public string EndDate { get; set; }
        public string Title { get; set; }
        public int ManagerUserId { get; set; }
        public int DeveloperUserId { get; set; }
        public int PriorityId { get; set; }
        public int StatuId { get; set; }

    }
}

