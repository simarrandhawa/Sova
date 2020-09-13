using System;
using System.Collections.Generic;
using System.Text;

namespace SovaApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int? AcceptedAnswerId { get; set; }
        public DateTime CreationDate { get; set; }

        public int Score { get; set; }
        public string Body { get; set; }

        public DateTime? ClosedDate { get; set; }
        public string Title { get; set; }

        public string Tags { get; set; }

        public int OwnerId { get; set; }

        public IEnumerable<Answer> Answers { get; set; }

        public IEnumerable<QuestionComments> QuestionComments { get; set; }


    }
}
