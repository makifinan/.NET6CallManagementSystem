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
    public class ManagerUsersController : Controller
    {
        private readonly IManagerUserWriteRepository _managerUserWriteRepository;
        private readonly IManagerUserReadRepository _managerUserReadRepository;

        public ManagerUsersController(IManagerUserWriteRepository managerUserWriteRepository, IManagerUserReadRepository managerUserReadRepository)
        {
            _managerUserWriteRepository = managerUserWriteRepository;
            _managerUserReadRepository = managerUserReadRepository;
        }

        [HttpGet("getall")]
        public IQueryable<ManagerUser> GetAll()
        {
            var response = _managerUserReadRepository.GetAll();
            return response;

        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(ManagerUser managerUser)
        {
            var response = await _managerUserWriteRepository.AddAsync(managerUser);
            return Ok(response);

        } 
    }
}

