using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data
{
    public class UsersDAO : IUserDAO
    {
        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentException("Null user");
            }
            _users.Add(user);
        }

        public void ChangeUser(User oldUser, User newUser)
        {
            int index = _users.IndexOf(oldUser);
            _users[index] = newUser;
        }

        public void DeleteUser(User user)
        {
            _users.Remove(user);
        }

        public IEnumerable<User> GetUsersList()
        {
            return _users;
        }
    }
}
