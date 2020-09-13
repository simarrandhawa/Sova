using System;
using System.Collections.Generic;
using System.Text;

namespace SovaApp.Models
{
   public class AnswerComments
    {
        public int Id { get; set; }

        public int AnswerId { get; set; }

        public int Score { get; set; }
        public string Body { get; set; }
        public DateTime CreationDate { get; set; }

        public int OwnerId { get; set; }

    }
}
