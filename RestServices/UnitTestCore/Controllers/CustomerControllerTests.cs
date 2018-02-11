using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestServices.Controllers;
using RestServices.DAL;
using RestServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestServices.Controllers.Tests
{
    [TestClass()]
    public class CustomerControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            Assert.IsInstanceOfType(CustomerDAL.GetCustomers(), typeof(List<CustomerDTO>));
        }

        [TestMethod()]
        public void GetTest1()
        {
            Assert.IsInstanceOfType(CustomerDAL.GetCustomer(10), typeof(CustomerDTO));
        }
    }
}