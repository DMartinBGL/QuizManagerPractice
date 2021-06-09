using Microsoft.EntityFrameworkCore;
using QuizManagerPractice.Models;
using System;

namespace QuizManagerPractice.Data
{
    public class MvcQuizContext : DbContext
    {
        public MvcQuizContext(DbContextOptions<MvcQuizContext> options)
            : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}
