using Microsoft.EntityFrameworkCore;
using SoftwareInterative_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareInterative_API.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {

        private readonly SoftwareInteractiveDbContext _dbContext;
        public QuestionRepository(SoftwareInteractiveDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Question> GetAll()
        {
            return _dbContext.Questions.Include(q => q.Options).ToList();
        }
    }
}
