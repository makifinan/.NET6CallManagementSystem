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
    public class DeveloperUsersController : Controller
    {
        private readonly IDeveloperUserWriteRepository _developerUserWriteRepository;
        private readonly IDeveloperUserReadRepository _developerUserReadRepository;

        public DeveloperUsersController(IDeveloperUserWriteRepository developerUserWriteRepository, IDeveloperUserReadRepository developerUserReadRepository)
        {
            _developerUserWriteRepository = developerUserWriteRepository;
            _developerUserReadRepository = developerUserReadRepository;
        }

        [HttpGet("getall")]
        public IQueryable<DeveloperUser> GetAll()
        {
            var response = _developerUserReadRepository.GetAll();
            return response;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(DeveloperUser developerUser)
        {
            var response = await _developerUserWriteRepository.AddAsync(developerUser);
            return Ok(response);
        }

    }
}

