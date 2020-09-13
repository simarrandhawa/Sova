using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using SovaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SovaApp.Repositories
{
    public class QuestionService
    {

        public Question GetQuestionsWithAnswersAndCommentsById(int id)
        {
            var db = new SovaContext();
            var fetchedQuestion = db.Questions.Include(q => q.Answers).ThenInclude(a => a.AnswerComments).Include(q => q.QuestionComments).Where(q => q.Id == id).First();

            return fetchedQuestion;

        }

        public IEnumerable<Question> GetFirstFiveQuestions()
        {
            var db = new SovaContext();
            var fiveQuestions = db.Questions.Take(5);
            return fiveQuestions;
        }
    }
}
