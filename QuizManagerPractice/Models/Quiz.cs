using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizManagerPractice.Models
{
    public class Quiz
    {
        public int QuizID { get; set; }
        public string QuizName { get; set; }
        public string Category { get; set; }
        [Display(Name = "Answers")]
        [MaxLength(4)]
        public ICollection<Question> Qestions { get; set; }
    }
}
