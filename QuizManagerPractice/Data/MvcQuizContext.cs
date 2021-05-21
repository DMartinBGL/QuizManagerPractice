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

        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }
    }
}
