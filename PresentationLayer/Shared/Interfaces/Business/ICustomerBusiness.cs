using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
   public interface ICustomerBusiness
    {
        List<Customer> GetAllCustomers();
        bool InsertCustomers(Customer c);
        bool DeleteCustomersById(int Id);
        Customer GetCustomersById(int Id);
        bool UpdateCustomersById(Customer c);
        Customer GetCustomersByUserAndPass(string User, string Pass);
    }
}
