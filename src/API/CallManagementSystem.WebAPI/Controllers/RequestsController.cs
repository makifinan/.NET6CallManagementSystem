using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Features.Requests.Commands.CreateRequest;
using CallManagementSystem.Application.Features.Requests.Dtos;
using CallManagementSystem.Application.Repositories;
using CallManagementSystem.Persistance.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CallManagementSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class RequestsController : BaseController
    {
        private readonly IRequestWriteRepository _requestWriteRepository;
        private readonly IRequestReadRepository _requestReadRepository;

        public RequestsController(IRequestWriteRepository requestWriteRepository, IRequestReadRepository requestReadRepository)
        {
            _requestWriteRepository = requestWriteRepository;
            _requestReadRepository = requestReadRepository;
        }

        /*[HttpPost("add")]
        public async Task<IActionResult> AddAsync([FromBody] CreateRequestCommand createRequestCommand)
        {
            CreatedRequestDto response = await Mediator.Send(createRequestCommand);
            return Created("", response);
        }*/

        [HttpGet("getbydeveloperrequest")]
        public IActionResult GetByDeveloperRequest(int id)
        {
            var result = _requestReadRepository.GetWhere(r => r.DeveloperUserId == id).ToList();
            return Ok(result);

        }

        [HttpGet("getbydeveloperrequestdetail")]
        public IActionResult GetByDeveloperRequestDetail(int id)
        {
            var result = _requestReadRepository.GetByDeveloperRequestDetail(id);
            return Ok(result);
        }

        [HttpGet("getall")]
        public IQueryable<Request> GetAll()
        {
            IQueryable<Request> response = _requestReadRepository.GetAll();
            return response;
        }

        [HttpGet("getallrequestdetail")]
        public List<RequestDetailDto> GetAllRequestDetail()
        {
            var result = _requestReadRepository.GetRequestDetail();
            return result;
        }

        [HttpPost("add2")]
        public async Task<IActionResult> AddAsync(Request request)
        {
            var response = await _requestWriteRepository.AddAsync(request);
            return Ok(response);
        }

        [HttpGet("getbyid")]
        public Task<Request> GetById(int id)
        {
            var response = _requestReadRepository.GetByIdAsync(id);
            return response;
        }

        [HttpGet("getbyidrequestdetail")]
        public IQueryable<SingleRequestDetailDto> GetByIdRequestDetail(int id)
        {
            var result = _requestReadRepository.GetByIdRequestDetail(id);
            return result;

        }

        [HttpPost("update")]
        public IActionResult Update(Request request)
        {
            _requestWriteRepository.Update(request);

            return Ok();
        }






        /* private readonly IRequestWriteRepository _requestWriteRepository;
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
         public async Task<IActionResult> AddAsync(Request request)
         {
             var response = await _requestWriteRepository.AddAsync(request);
             return Ok(response);
         }

         [HttpGet("getbyid")]
         public Task<Request> GetById(int id)
         {
             var response = _requestReadRepository.GetByIdAsync(id);
             return response;
         }

         [HttpPost("update")]
         public IActionResult Update(Request request)
         {
             _requestWriteRepository.Update(request);

             return Ok();
         }
        */

    }
}

