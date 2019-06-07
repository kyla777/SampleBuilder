using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace Business
{
    public abstract class State
    {
        protected UserProfile userProfile;
        protected int totalLikes;

        protected int upperLimit;
        protected int lowerLimit;

        public UserProfile UserProfile
        {
            get { return userProfile; }
            set { userProfile = value; }
        }
        public int TotalLikes
        {
            get { return totalLikes; }
            set { totalLikes = value; }
        }

        public abstract void AddLikes();
        public abstract void SubtractLikes();
    }
}
