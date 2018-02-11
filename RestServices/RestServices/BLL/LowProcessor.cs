using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestServices.Models;

namespace RestServices.BLL
{
    public class LowProcessor : ICustomerProcessor
    {
        public int EvaluateCustomer(CustomerDTO customer)
        {
            return (int)customer.CustomerPriority * 25;
        }
    }
}