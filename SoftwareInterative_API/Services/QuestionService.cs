using AutoMapper;
using SoftwareInterative_API.Dto;
using SoftwareInterative_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareInterative_API.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IMapper _mapper;
        private readonly IQuestionRepository _questionRepository;
        public QuestionService(IMapper mapper, IQuestionRepository questionRepository)
        {
            _mapper = mapper;
            _questionRepository = questionRepository;
        }

        public IEnumerable<QuestionDto> GetAll()
        {
            var questions = _questionRepository.GetAll();
            return _mapper.Map<List<QuestionDto>>(questions);
        }
    }
}
