using StoreApp.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp
{
    public static class TotalsHelper
    {
        public static decimal calculateTax(decimal subtotal, Customer user)
        {
            decimal taxRate = 0.055m;
            if (user.UserTypeId == (int)Constants.UserTypes.SENIOR || user.UserTypeId == (int)Constants.UserTypes.VETERAN)
            {
                taxRate = 0;
            }
            return subtotal * taxRate;
        }
    }
}
