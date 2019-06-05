using System;
using Data;
using Business;

namespace SampleBuilder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Instantiate Director
            Director director = new Director();

            // Instantiate Concrete Builders
            IProfile basic = new Basic();
            IProfile premium = new Premium();

            // Create 2 products => user profiles
            director.ConstructUserProfile(basic);
            UserProfile basicProfile = basic.GetUserProfile();
            Console.WriteLine("============================== BASIC ==============================");
            basicProfile.ShowUserProfile();

            director.ConstructUserProfile(premium);
            UserProfile premiumProfile = premium.GetUserProfile();
            Console.WriteLine("============================== PREMIUM ==============================");
            premiumProfile.ShowUserProfile();
        }
    }
}
