using System;
using Data;

namespace Business
{

    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.

    public interface IProfile
    {
        void BuildUserInfo();
        void BuildUserPosts();
        UserProfile GetUserProfile();
    }
}
