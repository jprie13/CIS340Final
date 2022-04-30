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

        public enum UserTypes {
            ADMIN = 1,
            STANDARD,
            SENIOR,
            VETERAN,
            EDUCATOR
        };
    }
}
