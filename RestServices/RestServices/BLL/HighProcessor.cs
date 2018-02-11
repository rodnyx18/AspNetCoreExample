using RestServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestServices.BLL
{
    public class HighProcessor : ICustomerProcessor
    {
        public int EvaluateCustomer(CustomerDTO customer)
        {
            return (int)customer.CustomerPriority * 100;
        }
    }
}