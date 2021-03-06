﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data;
using System.Configuration;

namespace BusinessLogic
{
    public class UsersBL
    {
        private IUserDAO _usersDAO;

        public UsersBL()
        {
            if (ConfigurationSettings.AppSettings["UseDB"] == "True")
            {
                _usersDAO = new UsersSqlDAO();
            }
            else
            {
                _usersDAO = new UsersDAO();
            }
        }

        private int CalculateNewID()
        {
            int lastId = 0;
            foreach (var user in _usersDAO.GetUsersList())
            {
                if (user.ID > lastId)
                {
                    lastId = user.ID;
                }
            }
            return lastId + 1;
        }

        public User CreateUser(string firstName, string lastName, DateTime birthDate)
        {
            int ID = CalculateNewID();
            User user = new User(ID, firstName, lastName, birthDate);
            return user;
        }

        public void AddUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentException("Null user");
            }
            _usersDAO.AddUser(user);
        }

        public void ChangeUser(User oldUser, User newUser)
        {
            if (oldUser == null || newUser == null)
            {
                throw new ArgumentException("Null user");
            }
            _usersDAO.ChangeUser(oldUser, newUser);
        }

        public void DeleteUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentException("Null user");
            }
            _usersDAO.DeleteUser(user);
        }

        public IEnumerable<User> GetUsersList()
        {
            return this._usersDAO.GetUsersList();
        }

        public IEnumerable<User> InitList()
        {
            return GetUsersList();
        }
    }
}
