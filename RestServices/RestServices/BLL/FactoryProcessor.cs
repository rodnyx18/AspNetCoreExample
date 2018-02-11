using RestServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestServices.BLL
{
    public class FactoryProcessor
    {
        public static ICustomerProcessor GetCustomerProcessor(CustomerDTO customer)
        {
            if (customer.CustomerPriority == 1)
            {
                return new HighProcessor();
            }
            else if (customer.CustomerPriority == 2)
            {
                return new MediumProcessor();
            }
            else
            {
                return new LowProcessor();
            }
        }

        public static ICustomerProcessor GetCustomerProcessor(int customerPriority)
        {
            if (customerPriority == 1)
            {
                return new HighProcessor();
            }
            else if (customerPriority == 2)
            {
                return new MediumProcessor();
            }
            else
            {
                return new LowProcessor();
            }
        }
    }
}