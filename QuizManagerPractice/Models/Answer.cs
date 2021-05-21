using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuizManagerPractice.Models
{
    public class Answer
    {
        public int AnswerID { get; set; }
        [Display(Name = "Answer")]
        public string AnswerName { get; set; }
        public bool Correct { get; set; }

        public Question Question { get; set; }
        public int QuestionID { get; internal set; }
    }
}
