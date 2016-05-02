using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implimentation
{
    class Customer : ICustomerService
    {
        public void AddCustomer()
        {
            var cust = new Data.Customers { Name = "Julia", Phone = "0452222366", Address = null, Orders = null  };
            using (var Context = new Data.TestDataEntities())
            {
                Context.Customers.Add(cust);
                Context.SaveChanges(); 

            }

        }

        public void GetAllCustomer()
        {
            using (var Context = new Data.TestDataEntities())
            {
                var cst = Context.Customers
                    .Where(p => p.CustomerID < 1000).ToList();  
                          
            }
        }
    }
}
