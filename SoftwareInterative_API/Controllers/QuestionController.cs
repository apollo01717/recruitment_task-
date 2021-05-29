using Microsoft.AspNetCore.Mvc;
using SoftwareInterative_API.Dto;
using SoftwareInterative_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareInterative_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
       [HttpGet]
       public ActionResult<IEnumerable<QuestionDto>> GetAll()
       {
            return Ok(_questionService.GetAll());
       }
       
    }
}
