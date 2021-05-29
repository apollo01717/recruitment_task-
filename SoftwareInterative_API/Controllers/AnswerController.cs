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
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerService _answerService;
        public AnswerController(IAnswerService answerService)
        {
            _answerService = answerService;
        }

        [HttpPost]
        public ActionResult AddAnswers([FromBody] List<CreateAnswerDto> answersDto)
        {
            _answerService.AddAnswers(answersDto);
            return Ok();
        }
    }
}
