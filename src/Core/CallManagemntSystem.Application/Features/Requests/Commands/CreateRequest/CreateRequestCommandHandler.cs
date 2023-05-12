using System;
using AutoMapper;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Features.Requests.Dtos;
using CallManagementSystem.Application.Repositories;
using MediatR;

namespace CallManagementSystem.Application.Features.Requests.Commands.CreateRequest
{
    public class CreateRequestCommandHandler : IRequestHandler<CreateRequestCommand,CreatedRequestDto>
    {
        IRequestWriteRepository _requestWriteRepository;
        IMapper _mapper;

        public CreateRequestCommandHandler(IRequestWriteRepository requestWriteRepository, IMapper mapper)
        {
            _requestWriteRepository = requestWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreatedRequestDto> Handle(CreateRequestCommand request, CancellationToken cancellationToken)
        {
            Request mappedRequest = _mapper.Map<Request>(request);
            Request response = await _requestWriteRepository.AddAsync(mappedRequest);
            CreatedRequestDto createdRequestDto = _mapper.Map<CreatedRequestDto>(response);
            return createdRequestDto;
        }
    }
}

