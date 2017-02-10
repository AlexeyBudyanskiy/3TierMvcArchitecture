﻿using AutoMapper;
using <%= SolutionName %>.BLL.DTO;
using <%= SolutionName %>.WEB.ViewModels;

namespace <%= SolutionName %>.WEB.AutomapperRegistrations
{
    public class ViewModelToDtoProfile : Profile
    {
        public ViewModelToDtoProfile()
        {
            CreateMap<ExampleViewModel, ExampleDto>();
        }
    }
}