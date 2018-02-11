using RestServices.DAL;
using RestServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestServices.Controllers
{
    //[Route("api/customer")]
    public class CustomerController : ApiController
    {
        // GET: api/Customer
        public List<CustomerDTO> Get()
        {
            return CustomerDAL.GetCustomers();           
        }

        // GET: api/Customer/5
        //public IQueryable<CustomerDTO> Get(int id)
        public CustomerDTO Get(int id)
        {
            return CustomerDAL.GetCustomer(id);
        }

        // POST: api/Customer
        public void Post([FromBody]CustomerDTO inputCustomer)
        {
            // why value is always null??? ***
            CustomerDAL.AddCustomer(inputCustomer);
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }
    }
}
