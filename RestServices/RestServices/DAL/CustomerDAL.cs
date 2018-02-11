using RestServices.BLL;
using RestServices.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestServices.DAL
{
    public class CustomerDAL
    {
        static FactoryEntities db = new FactoryEntities();

        public static List<CustomerDTO> GetCustomers()
        {
            List<CustomerDTO> customers = (from c in db.Customer
                            select new CustomerDTO()
                            {
                                Id = c.Id,
                                FirstName = c.FirstName,
                                LastName = c.LastName,
                                City = c.City,
                                Country = c.Country,
                                Phone = c.Phone,
                                CustomerPriority = c.CustomerPriority
                            }).ToList<CustomerDTO>();

            foreach (var itemCustomer in customers)
            {
                itemCustomer.CalculateProcessorNumber(FactoryProcessor.GetCustomerProcessor(itemCustomer));
            }
          
            return customers;                      
        }
        
        //public static IQueryable<CustomerDTO> GetCustomer(int id)
        public static CustomerDTO GetCustomer(int id)
        {
            // Find customer by id
            CustomerDTO customers = (from c in db.Customer
                                     where c.Id == id
                                     select new CustomerDTO()
                                     {
                                          Id = c.Id,
                                          FirstName = c.FirstName,
                                          LastName = c.LastName,
                                          City = c.City,
                                          Country = c.Country,
                                          Phone = c.Phone,
                                          CustomerPriority = c.CustomerPriority
                                     }).First<CustomerDTO>();

            // Ask object CustomerProcessor to FactoryProcessor. Abstract factory pattern
            ICustomerProcessor customerProcessor = FactoryProcessor.GetCustomerProcessor(customers);

            // Calculate processor number for the customer. Dependency injection by method
            customers.CalculateProcessorNumber(customerProcessor);                 

            return customers;
        }

        public static void AddCustomer(CustomerDTO customerDTO)
        {
            Customer customerEntity = new Customer() {
                
                FirstName = customerDTO.FirstName,
                LastName = customerDTO.LastName,
                City = customerDTO.City,
                Country = customerDTO.Country,
                Phone = customerDTO.Phone,
                CustomerPriority = customerDTO.CustomerPriority ?? 1            
            };

            using (FactoryEntities db = new FactoryEntities())
            {
                customerEntity.Id = db.Customer.Max(c => c.Id) + 1;
                db.Customer.Add(customerEntity);
                db.SaveChanges();
            }
        }
    }
}