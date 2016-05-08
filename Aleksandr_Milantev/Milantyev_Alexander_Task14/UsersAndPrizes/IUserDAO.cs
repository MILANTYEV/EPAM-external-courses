using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Data
{
    public interface IUserDAO
    {
        void AddUser(User user);
        void ChangeUser(User oldUser, User newUser);
        void DeleteUser(User user);
        IEnumerable<User> GetUsersList();
    }
}
