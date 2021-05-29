using AutoMapper;
using Moq;
using SoftwareInterative_API.Controllers;
using SoftwareInterative_API.Dto;
using SoftwareInterative_API.Entities;
using SoftwareInterative_API.Repositories;
using SoftwareInterative_API.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestProject
{
    public class QuestionControllerTest
    {
       
        [Fact]
        public void Should_Not_Be_Null()
        {
            var questionService = new Mock<IQuestionService>();
            questionService.Setup(repo => repo.GetAll()).Returns(GetQuestionsDto());
            var questionController = new QuestionController(questionService.Object);
            var stn = questionController.GetAll();
            Assert.NotNull(questionController.GetAll());

        }
        private IEnumerable<QuestionDto> GetQuestionsDto()
        {
            var questions = new List<QuestionDto>()
            {
                new QuestionDto()
                {
                    Id = 1,
                    Content = "What colors do you like?"
                },
                new QuestionDto()
                {
                    Id = 2,
                    Content = "What countries would you like to visit?"
                },
                new QuestionDto()
                {
                    Id = 3,
                    Content = "What type of music do you listen to?"
                }
            };
            return questions;
        }
    }
}
