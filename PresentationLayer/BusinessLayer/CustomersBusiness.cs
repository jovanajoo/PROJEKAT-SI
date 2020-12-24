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
        public CustomersRepository customersRepository;
        public CustomersBusiness()
        {
            this.customersRepository = new CustomersRepository();
        }

        public List<Customers> getAllCustomers()
        {
            return this.customersRepository.GetAllCustomers();
        }



        public bool InsertCustomers(Customers c)
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



        public Customers getCustomersById(int Id)
        {
            return this.customersRepository.GetAllCustomers().Where(c => c.CustomerID == Id).First();
        }



        public bool updateCustomersById(Customers c)
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
