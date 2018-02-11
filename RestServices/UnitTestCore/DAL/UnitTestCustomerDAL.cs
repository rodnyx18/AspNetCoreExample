using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestServices.DAL;
using RestServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestServices.DAL.Tests
{
    [TestClass()]
    public class UnitTestCustomerDAL
    {
        [TestMethod()]
        public void GetCustomersTest()
        {            
            Assert.IsInstanceOfType(CustomerDAL.GetCustomers(), typeof(List<CustomerDTO>));
        }

        [TestMethod()]
        public void GetCustomerTest()
        {
            Assert.IsInstanceOfType(CustomerDAL.GetCustomer(10), typeof(CustomerDTO));
        }

    }
}