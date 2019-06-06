using System;
using Data;

namespace Business
{
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. 

    public class Director
    {
        public void ConstructUserProfile(IProfile profile)
        {
            profile.BuildUserInfo();
            profile.BuildUserPosts();
        }
    }
}
