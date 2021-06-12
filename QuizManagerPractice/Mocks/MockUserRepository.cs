using QuizManagerPractice.Interfaces;
using QuizManagerPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizManagerPractice.Mocks
{
    public class MockUserRepository : IUserRepository
    {
        private List<User> _userList;
        public MockUserRepository()
        {
            _userList = new List<User>()
            {
                new User() { Id = 1, UserName = "Admin", Role = 1},
                new User() { Id = 2, UserName = "Editor", Role = 2},
                new User() { Id = 3, UserName = "BasicUser", Role = 3}
            };
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userList;
        }

        public User GetUser(int Id)
        {
            return _userList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
