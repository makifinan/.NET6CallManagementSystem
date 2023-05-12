using System;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Features.Requests.Dtos;

namespace CallManagementSystem.Application.Repositories
{
	public interface IRequestReadRepository : IReadRepository<Request>
	{
		List<RequestDetailDto> GetRequestDetail();
		List<RequestDetailDto> GetByDeveloperRequestDetail(int id);
		IQueryable<SingleRequestDetailDto> GetByIdRequestDetail(int id); 
	}
}

