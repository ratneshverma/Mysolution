using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecondSolution.Interface;
using SecondSolution.Resolver;
using Unity;
using Moq;
using System.Collections;
using SecondSolution.Model;
using System.Collections.Generic;
using SecondSolution.Utility;
using System.Linq;

namespace SecondSolution.Unit_Test
{
    [TestClass]
    public class ProductUtilityTest
    {

        #region Private Methods

        private List<IProduct> GetProductList(int number, string id, int price)
        {
            List<IProduct> listObject = new List<IProduct>();

            while (number > 0)
            {
                var mockProduct = new Mock<IProduct>();
                mockProduct.Setup(e => e.Id).Returns(id);
                mockProduct.Setup(e => e.Price).Returns(price);

                listObject.Add(mockProduct.Object);

                number--;
            }

            return listObject;
        }

        #endregion

        #region Test Methods

        [TestMethod]
        public void Test_GetTotalPrice_Product_Is_3A_Returns_130()
        {
            //Arrange
            var list = GetProductList(3, "A", 50);
            ProductUtility obj = new ProductUtility();

            //Act
            var totalPrice = obj.GetTotalPrice(list);

            //Assert
            Assert.AreEqual(totalPrice, 130, "Price should be same");

        }

        [TestMethod]
        public void Test_GetTotalPrice_Product_Is_2B_Returns_45()
        {
            //Arrange
            var list = GetProductList(2, "B", 30);
            ProductUtility obj = new ProductUtility();

            //Act
            var totalPrice = obj.GetTotalPrice(list);

            //Assert
            Assert.AreEqual(totalPrice, 45, "Price should be same");

        }

        [TestMethod]
        public void Test_GetTotalPrice_Product_Is_1CAnd1D_Returns_30()
        {
            //Arrange
            var list = GetProductList(1, "C", 20);
            list.Add(GetProductList(1, "D", 15).First());

            ProductUtility obj = new ProductUtility();

            //Act
            var totalPrice = obj.GetTotalPrice(list);

            //Assert
            Assert.AreEqual(totalPrice, 30, "Price should be same");
        }

        [TestMethod]
        public void Test_GetTotalPrice_ScenarioA_Returns_100()
        {
            //Arrange
            var list = GetProductList(1, "A", 50);
            list.Add(GetProductList(1, "B", 30).First());
            list.Add(GetProductList(1, "C", 20).First());

            ProductUtility obj = new ProductUtility();

            //Act
            var totalPrice = obj.GetTotalPrice(list);

            //Assert
            Assert.AreEqual(totalPrice, 100, "Price should be same");
        }

        [TestMethod]
        public void Test_GetTotalPrice_ScenarioB_Returns_370()
        {
            //Arrange
            var list = GetProductList(5, "A", 50);
            list.AddRange(GetProductList(5, "B", 30));
            list.Add(GetProductList(1, "C", 20).First());

            ProductUtility obj = new ProductUtility();

            //Act
            var totalPrice = obj.GetTotalPrice(list);

            //Assert
            Assert.AreEqual(totalPrice, 370, "Price should be same");
        }

        [TestMethod]
        public void Test_GetTotalPrice_ScenarioC_Returns_280()
        {
            //Arrange
            var list = GetProductList(3, "A", 50);
            list.AddRange(GetProductList(5, "B", 30));
            list.Add(GetProductList(1, "C", 20).First());
            list.Add(GetProductList(1, "D", 15).First());

            ProductUtility obj = new ProductUtility();

            //Act
            var totalPrice = obj.GetTotalPrice(list);

            //Assert
            Assert.AreEqual(totalPrice, 280, "Price should be same");
        }

        #endregion

    }
}
