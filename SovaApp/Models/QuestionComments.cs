using System;
using System.Collections.Generic;
using System.Text;

namespace SovaApp.Models
{
    public class QuestionComments
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public int Score { get; set; }
        public string Body { get; set; }
        public DateTime CreationDate { get; set; }

        public int OwnerId { get; set; }
    }
}
