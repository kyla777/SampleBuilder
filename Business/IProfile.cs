using System;
using Data;

namespace Business
{
    public interface IProfile
    {
        void BuildUserInfo();
        void BuildUserPosts();
        UserProfile GetUserProfile();
    }
}
