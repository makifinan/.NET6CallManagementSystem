using System;
using AutoMapper;
using CallManagamentSystem.Domain.Entities;
using CallManagementSystem.Application.Features.Requests.Commands.CreateRequest;
using CallManagementSystem.Application.Features.Requests.Dtos;

namespace CallManagementSystem.Application.Features.Requests.Profiles
{
    public class RequestProfile : Profile
    {
        public RequestProfile()
        {
            CreateMap<Request, CreatedRequestDto>().ReverseMap();
            CreateMap<Request, CreateRequestCommand>().ReverseMap();
        }
    }
}

