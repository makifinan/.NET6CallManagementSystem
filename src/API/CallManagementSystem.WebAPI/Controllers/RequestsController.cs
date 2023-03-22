using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CallManagementSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class RequestsController : Controller
    {
        private readonly IRequestWriteRepository _requestWriteRepository;
        private readonly IRequestReadRepository _requestReadRepository;

        public RequestsController(IRequestWriteRepository requestWriteRepository, IRequestReadRepository requestReadRepository)
        {
            _requestWriteRepository = requestWriteRepository;
            _requestReadRepository = requestReadRepository;
        }

        [HttpGet("getall")]
        public IQueryable<Request> GetAll()
        {
           IQueryable<Request> response = _requestReadRepository.GetAll();
            return response;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Request request)
        {
            var response = await _requestWriteRepository.AddAsync(request);
            return Ok(response);
        }

        
    }
}

