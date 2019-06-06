using System;
using Data;
using Repository;

namespace Business
{
    // The Concrete Builder classes follow the Builder interface and provide
    // specific implementations of the building steps.

    public class Premium : IProfile
    {
        private UserProfile userProfile = new UserProfile();
        private UserRepo userRepo = new UserRepo();
        private PostRepo postRepo = new PostRepo();

        // All production steps work with the same product instance.

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
            return this.userProfile;
        }
    }
}
