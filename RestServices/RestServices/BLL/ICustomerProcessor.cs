using RestServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestServices.BLL
{
    public interface ICustomerProcessor
    {
        int EvaluateCustomer(CustomerDTO customer);
    }
}
