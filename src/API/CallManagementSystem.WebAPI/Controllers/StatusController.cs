using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CallManagementSystem.Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using CallManagamentSystem.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CallManagementSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class StatusController : Controller
    {
        private readonly IStatuReadRepository _statuReadRepository;
        private readonly IStatuWriteRepository _statuWriteRepository;

        public StatusController(IStatuReadRepository statuReadRepository, IStatuWriteRepository statuWriteRepository)
        {
            _statuReadRepository = statuReadRepository;
            _statuWriteRepository = statuWriteRepository;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Post(Statu statu)
        {
            var response = await _statuWriteRepository.AddAsync(statu);
            return Ok(response);


        }

        [HttpGet("getall")]
        public IQueryable<Statu> GetAll()
        {
            var response = _statuReadRepository.GetAll();
            return response;
        }

        

        

    }    
}

