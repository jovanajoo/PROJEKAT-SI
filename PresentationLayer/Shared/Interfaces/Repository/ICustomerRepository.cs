using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        int DeleteCustomersById(int Id);
        int InsertCustomers(Customer c);
        int UpdateCustomersById(Customer c);


    }
}
