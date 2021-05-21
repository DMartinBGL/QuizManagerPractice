using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuizManagerPractice.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizManagerPractice.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcQuizContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcQuizContext>>()))
            {
                // Look for any Questions.
                if (context.Question.Any())
                {
                    return;   // DB has been seeded
                }

                context.Question.AddRange(
                    new Question
                    {
                        QuestionName = "Question 1",
                        Category = "Sport",
                        Answers = new List<Answer> { new Answer { AnswerID = 1, AnswerName = "Answer", Correct = true }  },
                    },

                    new Question
                    {
                        QuestionName = "Question 2",
                        Category = "Sport",
                        Answers = new List<Answer> { new Answer { AnswerID = 2, AnswerName = "Answer", Correct = true } },
                    },

                    new Question
                    {
                        QuestionName = "Question 3",
                        Category = "Sport",
                        Answers = new List<Answer> { new Answer { AnswerID = 3, AnswerName = "Answer", Correct = true } },
                    },

                    new Question
                    {
                        QuestionName = "Question 4",
                        Category = "Sport",
                        Answers = new List<Answer> { new Answer { AnswerID = 4, AnswerName = "Answer", Correct = true } },
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
