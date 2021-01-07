using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomersBusiness
    {
        public CustomerRepository customersRepository;
        public CustomersBusiness()
        {
            this.customersRepository = new CustomerRepository();
        }

        public List<Customer> getAllCustomers()
        {
            return this.customersRepository.GetAllCustomers();
        }



        public bool InsertCustomers(Customer c)
        {
            if (this.customersRepository.InsertCustomers(c) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool deleteCustomersById(int Id)
        {
            if (this.customersRepository.deleteCustomersById(Id) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public Customer getCustomersById(int Id)
        {
            return this.customersRepository.GetAllCustomers().Where(c => c.CustomerID == Id).First();
        }



        public bool updateCustomersById(Customer c)
        {
            if (this.customersRepository.updateCustomersById(c) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
