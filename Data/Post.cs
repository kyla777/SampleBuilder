using System;
namespace Data
{
    public class Post : Entity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int CreatedBy { get; set; }
        // public int NumOfLikes { get; set }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
