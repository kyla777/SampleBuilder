using System;
using Data;
using Repository;

namespace Business
{
    public class Basic : IProfile
    { 
        private UserProfile userProfile = new UserProfile();
        private UserRepo userRepo = new UserRepo();
        private PostRepo postRepo = new PostRepo();

        public Basic()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.userProfile = new UserProfile();
        }

        public void BuildUserInfo()
        {
            userProfile.user = userRepo.View(1);
        }

        public void BuildUserPosts()
        {

            userProfile.posts = postRepo.ViewAll(userProfile.user.Id, 5);
        }

        public UserProfile GetUserProfile()
        {
            UserProfile result = this.userProfile;

            this.Reset();

            return result;
        }
    }
}
