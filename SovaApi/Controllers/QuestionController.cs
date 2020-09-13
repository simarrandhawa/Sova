using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SovaApp.Models;
using SovaApp.Repositories;
namespace SovaApi.Controllers
{
    [ApiController]
    [Route("api/questions")]
    public class QuestionController : ControllerBase
    {
        [HttpGet("{questionId}")]
        public Question  GetQuestionById(int questionId)
        {
            var qs = new QuestionService();
            var result = qs.GetQuestionsWithAnswersAndCommentsById(questionId);
            return result;

            
        }
        [HttpGet]
        public IEnumerable <Question> FirstFive()
        {
            Console.WriteLine("api server started");
            var qs = new QuestionService();
            var result = qs.GetFirstFiveQuestions();
            return result;


        }
    }
}
