using SoftwareInterative_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareInterative_API.Repositories
{
    public interface IAnswerRepository
    {
        public void AddAnswers(List<Answer> answers);
    }
}
