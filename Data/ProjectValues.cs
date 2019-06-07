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

        public enum AccountLimit
        {
            BASIC = 5,
            PREMIUM = 0
        }
    }
}
