using SoftwareInterative_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareInterative_API.Repositories
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly SoftwareInteractiveDbContext _dbContext;

        public AnswerRepository(SoftwareInteractiveDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddAnswers(List<Answer> answers)
        {
            _dbContext.Answers.AddRange(answers);
            _dbContext.SaveChanges();
        }
    }
}
