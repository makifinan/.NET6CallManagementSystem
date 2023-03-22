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
    public class PrioritiesController : Controller
    {
        private readonly IPriorityWriteRepository _priorityWriteRepository;
        private readonly IPriorityReadRepository _priorityReadRepository;

        public PrioritiesController(IPriorityWriteRepository priorityWriteRepository, IPriorityReadRepository priorityReadRepository)
        {
            _priorityWriteRepository = priorityWriteRepository;
            _priorityReadRepository = priorityReadRepository;
        }

        [HttpGet("getall")]
        public IQueryable<Priority> GetAll()
        {
            var response = _priorityReadRepository.GetAll();
            return response;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Priority priority)
        {
            var response = await _priorityWriteRepository.AddAsync(priority);
            return Ok(response);
        }

    }
}

