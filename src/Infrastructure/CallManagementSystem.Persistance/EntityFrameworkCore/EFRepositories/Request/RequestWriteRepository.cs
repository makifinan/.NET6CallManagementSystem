using System;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Contexts;
using CallManagementSystem.Persistance.Repository;

namespace CallManagementSystem.Persistance.Repositories
{
    public class RequestWriteRepository : WriteRepository<Request>, IRequestWriteRepository
    {
        private readonly CallManagamentSystemDbContext _context;
        public RequestWriteRepository(CallManagamentSystemDbContext context) : base(context)
        {
            _context = context;
        }

        public void UpdateRequest(Request request)
        {
            var entity = _context.Requests.FirstOrDefault(r => r.Id == request.Id);
            if (entity == null)
            {
                // Talep bulunamadı, hata işleme yapılabilir veya uygun bir yanıt döndürülebilir.
                // Örneğin:
                Console.WriteLine("talep bulunamadı");
            }
            entity = _context.Requests.Find(request.Id);
            entity.PriorityId = request.PriorityId;
            entity.StatuId = request.StatuId;
            entity.DeveloperUserId = request.DeveloperUserId;
            entity.Description = request.Description;
            entity.Title = request.Title;
            entity.EndDate = request.EndDate;
            _context.SaveChanges();

        }
    }
}

