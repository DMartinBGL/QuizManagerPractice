using QuizManagerPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizManagerPractice.Interfaces
{
    public interface IUserRepository
    {
        User GetUser(int Id);
        IEnumerable<User> GetAllUsers();
    }
}
