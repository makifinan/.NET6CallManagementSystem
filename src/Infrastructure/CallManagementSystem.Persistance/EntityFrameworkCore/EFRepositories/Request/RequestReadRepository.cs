using System;
using System.Linq;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Features.Requests.Dtos;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Contexts;

namespace CallManagementSystem.Persistance.Repositories
{
    public class RequestReadRepository : ReadRepository<Request>, IRequestReadRepository
    {
        private readonly CallManagamentSystemDbContext _context;
        public RequestReadRepository(CallManagamentSystemDbContext context) : base(context)
        {
            this._context = context;
        }
        


        public List<RequestDetailDto> GetRequestDetail()
        {
            var joinResult = from request in _context.Requests
                             join dev in _context.DeveloperUsers on request.DeveloperUserId equals dev.Id
                             join pri in _context.Priorities on request.PriorityId equals pri.Id
                             join sta in _context.Status on request.StatuId equals sta.Id
                             orderby request.GeneratedDate descending
                             select new RequestDetailDto
                             {

                                 Id = request.Id,
                                 GeneratedDate = request.GeneratedDate,
                                 EndDate = request.EndDate,
                                 Title = request.Title,
                                 FirstName = dev.FirstName,
                                 LastName = dev.LastName,
                                 PriorityName = pri.PriorityName,
                                 StatuName = sta.StatuName,

                             };

            return joinResult.ToList();

        }
        public List<RequestDetailDto> GetByDeveloperRequestDetail(int id)
        {
            var joinResult = from request in _context.Requests
                             join dev in _context.DeveloperUsers on request.DeveloperUserId equals dev.Id
                             join pri in _context.Priorities on request.PriorityId equals pri.Id
                             join sta in _context.Status on request.StatuId equals sta.Id
                             where request.DeveloperUserId == id
                             orderby request.GeneratedDate descending
                             select new RequestDetailDto
                             {

                                 Id = request.Id,
                                 GeneratedDate = request.GeneratedDate,
                                 EndDate = request.EndDate,
                                 Title = request.Title,
                                 FirstName = dev.FirstName,
                                 LastName = dev.LastName,
                                 PriorityName = pri.PriorityName,
                                 StatuName = sta.StatuName,

                             };

            return joinResult.ToList();

        }
        public IQueryable<SingleRequestDetailDto> GetByIdRequestDetail(int id)
        {
            var joinResult = from request in _context.Requests
                             join dev in _context.DeveloperUsers on request.DeveloperUserId equals dev.Id
                             join pri in _context.Priorities on request.PriorityId equals pri.Id
                             join sta in _context.Status on request.StatuId equals sta.Id
                             where request.Id == id
                             select new SingleRequestDetailDto
                             {
                                 Id=request.Id,
                                 Description=request.Description,
                                 GeneratedDate = request.GeneratedDate,
                                 EndDate = request.EndDate,
                                 FirstName = dev.FirstName,
                                 LastName = dev.LastName,
                                 PriorityName = pri.PriorityName,
                                 StatuName = sta.StatuName,
                                 Title = request.Title
                                 
                             };
            return joinResult;
        }
    }
}

