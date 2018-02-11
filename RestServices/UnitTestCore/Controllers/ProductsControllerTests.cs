using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestServices.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestServices.Controllers.Tests
{
    [TestClass()]
    public class ProductsControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            // Arrange
            ProductsController controller = new ProductsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void DetailsTest()
        {

        }

        [TestMethod()]
        public void CreateTest()
        {

        }

        [TestMethod()]
        public void CreateTest1()
        {

        }

        [TestMethod()]
        public void EditTest()
        {

        }

        [TestMethod()]
        public void EditTest1()
        {

        }

        [TestMethod()]
        public void DeleteTest()
        {

        }

        [TestMethod()]
        public void DeleteConfirmedTest()
        {

        }
    }
}