using AutoMapper;
using SoftwareInterative_API.Dto;
using SoftwareInterative_API.Entities;
using SoftwareInterative_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareInterative_API.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IMapper _mapper;
        private readonly IAnswerRepository _answerRepository;
        public AnswerService(IMapper mapper,IAnswerRepository answerRepository)
        {
            _mapper = mapper;
            _answerRepository = answerRepository;
        }

        public void AddAnswers(List<CreateAnswerDto> answersDto)
        {
            var answers = _mapper.Map<List<Answer>>(answersDto);
            _answerRepository.AddAnswers(answers);
        }
    }
}
