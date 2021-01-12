using DataAccessLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerBusiness : ICustomerBusiness
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerBusiness(ICustomerRepository _customerRepository)
        {
            this.customerRepository = _customerRepository;
        }
        public List<Customer> GetAllCustomers()
        {
            return this.customerRepository.GetAllCustomers();
        }


        public bool InsertCustomers(Customer c)
        {
            if (this.customerRepository.InsertCustomers(c) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool DeleteCustomersById(int Id)
        {
            if (this.customerRepository.DeleteCustomersById(Id) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public Customer GetCustomersById(int Id)
        {
            return this.customerRepository.GetAllCustomers().Where(c => c.CustomerID == Id).First();
        }



        public bool UpdateCustomersById(Customer c)
        {
            if (this.customerRepository.UpdateCustomersById(c) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public Customer GetCustomersByUserAndPass(string User, string Pass)
        {
            return this.customerRepository.GetAllCustomers().FirstOrDefault(c =>
            {
                if (c.Username == User && c.Password == Pass)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

        }

        int ICustomerBusiness.InsertCustomers(Customer c)
        {
            throw new NotImplementedException();
        }

        int ICustomerBusiness.DeleteCustomersById(int Id)
        {
            throw new NotImplementedException();
        }

        int ICustomerBusiness.UpdateCustomersById(Customer c)
        {
            throw new NotImplementedException();
        }
    }


}
