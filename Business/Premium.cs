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
        UserRepo userRepo = new UserRepo();
        PostRepo postRepo = new PostRepo();

        // All production steps work with the same product instance.
        public void BuildUserInfo(int userId)
        {
            userProfile.user = userRepo.View(userId);
        }

        public void BuildUserPosts(int userId, int limit)
        {

            userProfile.posts = postRepo.ViewAll(userId, limit);
        }

        public UserProfile GetUserProfile()
        {
            return this.userProfile;
        }

        // ========== STATE ============
        //public Premium(State state)
        //{
        //    this.totalLikes = state.TotalLikes;
        //    Initialize();
        //}

        //private void Initialize()
        //{
        //    lowerLimit = (int)ProjectValues.AccountStateLimit.PREMIUM_LOWER;
        //    upperLimit = (int)ProjectValues.AccountStateLimit.PREMIUM_UPPER;
        //}

        //public override void AddLikes()
        //{
        //    totalLikes += 1;
        //}

        //public override void SubtractLikes()
        //{
        //    totalLikes -= 1;
        //}
    }
}
