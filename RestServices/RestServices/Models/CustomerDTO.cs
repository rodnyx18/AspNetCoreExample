using RestServices.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestServices.Models
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public Nullable<int> CustomerPriority { get; set; }
        public int ProcessorNumber { get; set; }

        // Implementing dependency injection by method
        public void CalculateProcessorNumber(ICustomerProcessor processor)
        {
            if (processor != null)
            {
                this.ProcessorNumber = processor.EvaluateCustomer(this);
            }
        }
    }
}