using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreApp;
using StoreApp.Models.DataLayer;

namespace StoreTests
{
    [TestClass]
    public class CheckoutFormTests
    {
        [TestMethod]
        public void CalculateTaxStandard()
        {
            var user = new Customer();
            user.UserTypeId = (int)StoreApp.Constants.UserTypes.STANDARD;

            var tax = TotalsHelper.calculateTax(100, user);

            Assert.IsTrue(tax > 0);
        }

        [TestMethod]
        public void CalculateTaxSenior()
        {
            var user = new Customer();
            user.UserTypeId = (int)StoreApp.Constants.UserTypes.SENIOR;

            var tax = TotalsHelper.calculateTax(100, user);

            Assert.IsTrue(tax == 0);
        }

        [TestMethod]
        public void CalculateTaxVeteran()
        {
            var user = new Customer();
            user.UserTypeId = (int)StoreApp.Constants.UserTypes.VETERAN;

            var tax = TotalsHelper.calculateTax(100, user);

            Assert.IsTrue(tax == 0);
        }
    }
}
