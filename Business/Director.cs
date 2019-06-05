using System;
using Data;

namespace Business
{
    public class Director
    {
        public void ConstructUserProfile(IProfile profile)
        {
            profile.BuildUserInfo();
            profile.BuildUserPosts();
        }
    }
}
