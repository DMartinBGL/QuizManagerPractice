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
                        QuestionName = "When Harry Met Sally",
                        Category = "Romantic Comedy",
                        Answers = new List<Answer> { new Answer { AnswerID = 1, AnswerName = "Answer", Correct = true }  },
                    },

                    new Question
                    {
                        QuestionName = "When Harry Met Sally",
                        Category = "Romantic Comedy",
                        Answers = new List<Answer> { new Answer { AnswerID = 1, AnswerName = "Answer", Correct = true } },
                    },

                    new Question
                    {
                        QuestionName = "When Harry Met Sally",
                        Category = "Romantic Comedy",
                        Answers = new List<Answer> { new Answer { AnswerID = 1, AnswerName = "Answer", Correct = true } },
                    },

                    new Question
                    {
                        QuestionName = "When Harry Met Sally",
                        Category = "Romantic Comedy",
                        Answers = new List<Answer> { new Answer { AnswerID = 1, AnswerName = "Answer", Correct = true } },
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
