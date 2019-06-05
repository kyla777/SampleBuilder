using System;
using Data;
using Repository;

namespace Business
{
    public class Premium : IProfile
    {
        private UserProfile userProfile = new UserProfile();
        private UserRepo userRepo = new UserRepo();
        private PostRepo postRepo = new PostRepo();

        public Premium()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.userProfile = new UserProfile();
        }

        public void BuildUserInfo()
        {
            userProfile.user = userRepo.View(2);
        }

        public void BuildUserPosts()
        {

            userProfile.posts = postRepo.ViewAll(userProfile.user.Id, 0);
        }

        public UserProfile GetUserProfile()
        {
            UserProfile result = this.userProfile;

            this.Reset();

            return result;
        }
    }
}
