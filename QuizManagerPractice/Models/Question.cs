using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuizManagerPractice.Models
{
    public class Question
    {
        [Display(Name = "ID")]
        public int QuestionID { get; set; }
        [Display(Name = "Question")]
        public string QuestionName { get; set; }
        public string Category { get; set; }
        [Display(Name = "Answers")]
        [MaxLength(4)]
        public ICollection<Answer>  Answers { get; set; }
    }
}
