using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp
{
    static class Constants
    {
        public const int ADD = 1;
        public const int EDIT = 2;

        public enum UserTypes
        {
            ADMIN = 1,
            STANDARD,
            SENIOR,
            VETERAN,
            EDUCATOR
        };

        public static Dictionary<int, string> TimeframeOptions = new Dictionary<int, string>()
        {
            {0, "All time" },
            {30, "1 month" },
            {60, "2 months" },
            {90, "3 months" },
            {180, "6 months" },
            {365, "1 year" },
        };
    }
}
