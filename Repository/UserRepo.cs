using System;
using Data;
using System.Collections.Generic;

namespace Repository
{
    public class UserRepo
    {
        List<User> users = new List<User>
        {
            new User
            {
                Id = 1,
                FirstName = "Kyla",
                LastName = "Calpito",
                Birthdate = DateTime.Parse("06/05/1997"),
                DateCreated = DateTime.Parse("06/01/2019")
            },
            new User
            {
                Id = 2,
                FirstName = "Den",
                LastName = "Hernandez",
                Birthdate = DateTime.Parse("12/04/1992"),
                DateCreated = DateTime.Parse("06/01/2019")
            }
        };

        public void Create(User user)
        {
            user.DateCreated = DateTime.Now;
            users.Add(user);
        }

        public User View(int id)
        {
            User user = users.Find(item => item.Id == id);
            return user;
        }

        public List<User> ViewAll()
        {
            return users;
        }

        public void Update(int id, string firstName, string lastName, DateTime birthDate)
        {
            int index = users.FindIndex(item => item.Id == id);
            User user = users[index];
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Birthdate = birthDate;
        }

        public void Delete(int id)
        {
            users.RemoveAll(item => item.Id == id);
        }
    }
}
