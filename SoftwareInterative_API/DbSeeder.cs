using SoftwareInterative_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareInterative_API
{
    public class DbSeeder
    {
        private readonly SoftwareInteractiveDbContext _dbContext;
        public DbSeeder(SoftwareInteractiveDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if(!_dbContext.Questions.Any())
                {
                    var questions = GetQuestions();
                    _dbContext.AddRange(questions);
                    _dbContext.SaveChanges();
                } 
                if(!_dbContext.Options.Any())
                {
                    var options = GetOptions();
                    _dbContext.AddRange(options);
                    _dbContext.SaveChanges();
                }
            }
        }
        public IEnumerable<Question> GetQuestions()
        {
            var questions = new List<Question>()
            {
                new Question()
                {
                    Content = "What colors do you like?"
                },
                new Question()
                {
                    Content = "What countries would you like to visit?"
                },
                new Question()
                {
                    Content = "What type of music do you listen to?"
                }
            };
            return questions;
        }  
        public IEnumerable<Option> GetOptions()
        {
            var options = new List<Option>()
            {
             new Option()
             {
                 Content = "Blue",
                 QuestionId = 1
             }, 
             new Option()
             {
                 Content = "Red",
                 QuestionId = 1
             }, 
             new Option()
             {
                 Content = "White",
                 QuestionId = 1
             }, 
             new Option()
             {
                 Content = "Brazil",
                 QuestionId = 2
             }, 
             new Option()
             {
                 Content = "Usa",
                 QuestionId = 2
             }, 
             new Option()
             {
                 Content = "Russia",
                 QuestionId = 2
             }, 
             new Option()
             {
                 Content = "Pop",
                 QuestionId = 3
             }, 
             new Option()
             {
                 Content = "Rock",
                 QuestionId = 3
             }, 
             new Option()
             {
                 Content = "Heavy Metal",
                 QuestionId = 3
             },
            };
            return options;
        }

    }
}
