using System;
using System.Collections.Generic;

namespace Data
{
    public class UserProfile
    {
        // It makes sense to use the Builder pattern only when your products are
        // quite complex and require extensive configuration.

        public User user = new User();
        public List<Post> posts = new List<Post>();

        public void ShowUserProfile()
        {
            Console.WriteLine("Full name: {0} {1}", user.FirstName, user.LastName);
            Console.WriteLine("Birthday: {0}", user.Birthdate.Date);
            Console.WriteLine("Member since: {0}", user.DateCreated.Date);

            foreach (var post in posts)
            {
                Console.WriteLine();
                Console.WriteLine("Title: {0}", post.Title);
                Console.WriteLine("{0}", post.Content);
                Console.WriteLine("Posted on: {0}", post.DateCreated.Date);
            }
        }
    }
}
