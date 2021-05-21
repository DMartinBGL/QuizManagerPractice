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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Answer>().HasOne(u => u.Question).WithMany(a => a.Answers).HasForeignKey(b => b.QuestionID);
            base.OnModelCreating(builder);
        }

        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }
    }
}
