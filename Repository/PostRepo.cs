using System;
using Data;
using System.Collections.Generic;

namespace Repository
{
    public class PostRepo
    {
        List<Post> posts = new List<Post>
        {
            new Post
            {
                Id = 1,
                Title = "First Day",
                Content = "First day of social media is amazing!",
                CreatedBy = 1,
                DateCreated = DateTime.Parse("06-01-2019")
            },
            new Post
            {
                Id = 2,
                Title = "Second Day",
                Content = "Second day of social media is more amazing!",
                CreatedBy = 1,
                DateCreated = DateTime.Parse("06-02-2019")
            },
            new Post
            {
                Id = 3,
                Title = "Third Day",
                Content = "Third day of social media is so much more amazing!",
                CreatedBy = 1,
                DateCreated = DateTime.Parse("06-03-2019")
            },
            new Post
            {
                Id = 4,
                Title = "Fourth Day",
                Content = "Fourth day of social media is so much more amazing!",
                CreatedBy = 1,
                DateCreated = DateTime.Parse("06-04-2019")
            },
            new Post
            {
                Id = 5,
                Title = "Fifth Day",
                Content = "Fifth day of social media is so much moore amazing!",
                CreatedBy = 1,
                DateCreated = DateTime.Parse("06-05-2019")
            },
            new Post
            {
                Id = 6,
                Title = "Sixth Day",
                Content = "Sixth day of social media is so much mooore amazing!",
                CreatedBy = 1,
                DateCreated = DateTime.Parse("06-06-2019")
            },
            new Post
            {
                Id = 7,
                Title = "First Day",
                Content = "First day of social media is amazing!",
                CreatedBy = 2,
                DateCreated = DateTime.Parse("06-01-2019")
            },
            new Post
            {
                Id = 8,
                Title = "Second Day",
                Content = "Second day of social media is more amazing!",
                CreatedBy = 2,
                DateCreated = DateTime.Parse("06-02-2019")
            },
            new Post
            {
                Id = 9,
                Title = "Third Day",
                Content = "Third day of social media is so much more amazing!",
                CreatedBy = 2,
                DateCreated = DateTime.Parse("06-03-2019")
            },
            new Post
            {
                Id = 10,
                Title = "Fourth Day",
                Content = "Fourth day of social media is so much more amazing!",
                CreatedBy = 2,
                DateCreated = DateTime.Parse("06-04-2019")
            },
            new Post
            {
                Id = 11,
                Title = "Fifth Day",
                Content = "Fifth day of social media is so much moore amazing!",
                CreatedBy = 2,
                DateCreated = DateTime.Parse("06-05-2019")
            },
            new Post
            {
                Id = 12,
                Title = "Sixth Day",
                Content = "Sixth day of social media is so much mooore amazing!",
                CreatedBy = 2,
                DateCreated = DateTime.Parse("06-06-2019")
            }
        };

        public void Create(Post post)
        {
            post.DateCreated = DateTime.Now;
            posts.Add(post);
        }

        public Post View(int id)
        {
            Post post = posts.Find(item => item.Id == id);
            return post;
        }

        public List<Post> ViewAll(int userId, int limit)
        {
            List<Post> postsBy = posts.FindAll(item => item.CreatedBy == userId);
            if (limit == 0)
            {
                return postsBy;
            }
            else
            {
                return postsBy.GetRange(0, limit);
            }
        }

        public void Update(int id, string title, string content)
        {
            int index = posts.FindIndex(item => item.Id == id);
            Post post = posts[index];
            post.Title = title;
            post.Content = content;
            post.DateModified = DateTime.Now;
        }

        public void Delete(int id)
        {
            posts.RemoveAll(item => item.Id == id);
        }
    }
}
