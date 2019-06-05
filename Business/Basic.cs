using System;
using Data;
using Repository;

namespace Business
{

    // The Concrete Builder classes follow the Builder interface and provide
    // specific implementations of the building steps.

    public class Basic : IProfile
    { 
        private UserProfile userProfile = new UserProfile();
        private UserRepo userRepo = new UserRepo();
        private PostRepo postRepo = new PostRepo();

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.

        public Basic()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.userProfile = new UserProfile();
        }

        // All production steps work with the same product instance.

        public void BuildUserInfo()
        {
            userProfile.user = userRepo.View(1);
        }

        public void BuildUserPosts()
        {

            userProfile.posts = postRepo.ViewAll(userProfile.user.Id, 5);
        }

        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body.

        public UserProfile GetUserProfile()
        {
            UserProfile result = this.userProfile;

            this.Reset();

            return result;
        }
    }
}
