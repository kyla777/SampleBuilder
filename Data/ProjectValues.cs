using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public static class ProjectValues
    {
        public enum AccountType
        {
            BASIC,
            PREMIUM
        }

        public enum AccountPostLimit
        {
            BASIC = 4,
            PREMIUM = 0
        }

        public enum AccountStateLimit
        {
            BASIC_LOWER = -10,
            BASIC_UPPER = 10,
            PREMIUM_LOWER = 10,
            PREMIUM_UPPER = 20
        }

    }
}
