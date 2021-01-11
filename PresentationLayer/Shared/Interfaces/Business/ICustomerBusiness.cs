using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    interface ICustomerBusiness
    {
        List<Customer> GetAllCustomers();
        int InsertCustomers(Customer c);
        int DeleteCustomersById(int Id);
        Customer GetCustomersById(int Id);
        int UpdateCustomersById(Customer c);
    }
}
