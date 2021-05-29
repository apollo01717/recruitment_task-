using SoftwareInterative_API.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareInterative_API.Services
{
    public interface IQuestionService
    {
        public IEnumerable<QuestionDto> GetAll();
    }
}
