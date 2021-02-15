using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model = VirginMedia.Services.Models;

namespace VirginMedia.Scenario.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Data.Model.Scenario,Model.Scenario>()
            .ForMember( dest => dest.SampleDate, opt => opt.MapFrom(src => src.SampleDateTime))
            .ForMember(dest => dest.CreationDate, opt => opt.MapFrom(src => src.CreationDateTime));
        }
    }
}
