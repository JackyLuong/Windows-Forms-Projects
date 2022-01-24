using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsData.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void InventoryValueQohZeroTest()
        {
            //arrange
            Product prod = new Product("test", 1.99m, 0);
            decimal expectedInventory = 0;
            decimal actualInventory;

            //act
            actualInventory = prod.InventoryValue();

            // assert
            Assert.AreEqual(expectedInventory, actualInventory);
        }

        [TestMethod()]
        public void InventoryValueQohOneTest()
        {
            //arrange
            Product prod = new Product("test", 1.99m, 0);
            decimal expectedInventory = 1.99m;
            decimal actualInventory;

            //act
            actualInventory = prod.InventoryValue();

            // assert
            Assert.AreEqual(expectedInventory, actualInventory);
        }


        [TestMethod()]
        public void InventoryValueQoh10Test()
        {
            //arrange
            Product prod = new Product("test", 1.99m, 0);
            decimal expectedInventory = 10 * 1.99m;
            decimal actualInventory;

            //act
            actualInventory = prod.InventoryValue();

            // assert
            Assert.AreEqual(expectedInventory, actualInventory);
        }
    }
}