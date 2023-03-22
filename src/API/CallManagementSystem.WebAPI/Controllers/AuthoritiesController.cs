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
    public class AuthoritiesController : Controller
    {
        private readonly IAuthorityWriteRepository _authorityWriteRepository;
        private readonly IAuthorityReadRepository _authorityReadRepository;

        public AuthoritiesController(IAuthorityWriteRepository authorityWriteRepository, IAuthorityReadRepository authorityReadRepository)
        {
            _authorityWriteRepository = authorityWriteRepository;
            _authorityReadRepository = authorityReadRepository;
        }

        [HttpGet("getall")]
        public IQueryable<Authority> GetAll()
        {
            var response = _authorityReadRepository.GetAll();
            return response;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Authority authority)
        {
           var response = await _authorityWriteRepository.AddAsync(authority);
            return Ok(response);
        }


    }
}

