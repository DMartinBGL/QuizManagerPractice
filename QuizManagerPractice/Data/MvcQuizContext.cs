using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuizManagerPractice.Models;
using System;

namespace QuizManagerPractice.Data
{
    public class MvcQuizContext : IdentityDbContext
    {
        public MvcQuizContext(DbContextOptions<MvcQuizContext> options)
            : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}
