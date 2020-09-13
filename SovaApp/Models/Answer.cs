using System;
using System.Collections.Generic;
using System.Text;

namespace SovaApp.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        public int Score { get; set; }
        public string  Body { get; set; }
        public int QuestionId { get; set; }
        public int OwnerId { get; set; }

        public IEnumerable<AnswerComments> AnswerComments { get; set; }

    }
}
