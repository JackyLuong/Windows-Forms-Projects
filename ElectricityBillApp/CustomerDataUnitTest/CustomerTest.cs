using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElectricityBillApp
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod()]
        public void CalcBillAmounttWithNegativeKWh()
        {
            //arrange
            decimal amount = -60;
            Customer cust = new Customer("a", "a", amount);
            decimal expectedAmount = (60 * cust.KWhRate) +cust.AdminCharge;
            decimal actualAmount;

            //Action
            actualAmount = cust.BillAmount;

            //Assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }
        [TestMethod()]
        public void CalcBillAmounttWithZeroKWh()
        {
            //arrange
            decimal amount = 0;
            Customer cust = new Customer("a", "a", amount);
            decimal expectedAmount = cust.AdminCharge;
            decimal actualAmount;

            //Action
            actualAmount = cust.BillAmount;

            //Assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }
        [TestMethod()]
        public void CalcBillAmounttWithPositiveKWh()
        {
            //arrange
            decimal amount = 30;
            Customer cust = new Customer("a", "a", amount);
            decimal expectedAmount = (30 * cust.KWhRate) + cust.AdminCharge;
            decimal actualAmount;

            //Action
            actualAmount = cust.BillAmount;

            //Assert
            Assert.AreEqual(expectedAmount, actualAmount);
        }
    }
}
