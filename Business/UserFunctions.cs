using System;
using System.Collections.Generic;
using Repository;
using Data;

namespace Business
{
    public class UserFunctions
    {
        UserRepo repo = new UserRepo();

        public void Create(int id, string firstName, string lastName, DateTime birthDate)
        {
            User user = new User();
            user.Id = id;
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Birthdate = birthDate;

            repo.Create(user);
        }

        public User View(int id)
        {
            User user = repo.View(id);
            return user;
        }

        public List<User> ViewAll()
        {
            List<User> users = repo.ViewAll();
            return users;
        }

        public void Update(int id, string firstName, string lastName, DateTime birthDate)
        {
            repo.Update(id, firstName, lastName, birthDate);
        }
    }
}
