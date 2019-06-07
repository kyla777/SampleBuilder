using System;
using Data;
using Business;

namespace SampleBuilder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter User ID to view profile: ");
            int userId = int.Parse(Console.ReadLine());

            UserFunctions userFunctions = new UserFunctions();

            User user = userFunctions.View(userId);

            // Instantiate Director
            Director director = new Director();

            // Instantiate Concrete Builders
            if(user.AccountType == ProjectValues.AccountType.BASIC.ToString())
            {
                IProfile basic = new Basic();
                director.ConstructUserProfile(basic, userId, (int)ProjectValues.AccountPostLimit.BASIC);
                UserProfile basicProfile = basic.GetUserProfile();
                Console.WriteLine("=============================== BASIC ===============================");
                basicProfile.ShowUserProfile();
            }

            if(user.AccountType == ProjectValues.AccountType.PREMIUM.ToString())
            {
                IProfile premium = new Premium();
                director.ConstructUserProfile(premium, userId, (int)ProjectValues.AccountPostLimit.PREMIUM);
                UserProfile premiumProfile = premium.GetUserProfile();
                Console.WriteLine("============================== PREMIUM ==============================");
                premiumProfile.ShowUserProfile();
            }            

            Console.ReadKey();
        }
    }
}
