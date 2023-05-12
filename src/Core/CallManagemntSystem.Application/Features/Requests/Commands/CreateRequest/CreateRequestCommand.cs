using System;
using AutoMapper;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Features.Requests.Dtos;
using CallManagementSystem.Application.Repositories;
using MediatR;

namespace CallManagementSystem.Application.Features.Requests.Commands.CreateRequest
{
	public class CreateRequestCommand : IRequest<CreatedRequestDto>
	{
		public string Description { get; set; }
		public string EndDate { get; set; }
		public string Title { get; set; }

		public int ManagerUserId { get; set; }
		public int PriorityId { get; set; }
		public int StatuId { get; set; }
		public int DeveloperUserId { get; set; }
        
    }
}

