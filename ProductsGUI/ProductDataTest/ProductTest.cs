using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProductsGUI
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void IsInventoryValueAccurate()
        {
            //arrange
            Product prod = new Product("test", 1.99m, 10);

            decimal ExpectedInVal = 10 * 1.99m;
            decimal ActualInVal;
            double delta = 0.03;

            //act
            ActualInVal = prod.IventoryValue();

            //Assert
            Assert.AreEqual((double)ExpectedInVal, (double)ActualInVal, delta);
        }
    }
}
