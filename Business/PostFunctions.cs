using System;
using System.Collections.Generic;
using Repository;
using Data;

namespace Business
{
    public class PostFunctions
    {
        PostRepo repo = PostRepo.GetPostRepo();
        public void Create(int id, string title, string content, int createdBy)
        {
            Post post = new Post();
            post.Id = id;
            post.Title = title;
            post.Content = content;
            post.CreatedBy = createdBy;

            repo.Create(post);
        }

        public Post View(int id)
        {
            // TODO:
            // Deconstruct post before sending to front end
            Post post = repo.View(id);
            return post;
        }

        public List<Post> ViewAll(int userId, int limit)
        {
            // TODO:
            // Deconstruct posts before sending to front end
            List<Post> posts = repo.ViewAll(userId, limit);
            return posts;
        }

        public void Update(int id, string title, string content)
        {
            repo.Update(id, title, content);
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }
    }
}
