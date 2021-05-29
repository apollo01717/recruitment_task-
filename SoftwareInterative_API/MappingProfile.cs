using AutoMapper;
using SoftwareInterative_API.Dto;
using SoftwareInterative_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareInterative_API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Option, OptionDto>();
            CreateMap<OptionDto, Option>(); 
            
            CreateMap<Question, QuestionDto>();
            CreateMap<QuestionDto, Question>();   
            CreateMap<Answer, CreateAnswerDto>();
            CreateMap<CreateAnswerDto, Answer>();

        }
    }
}
