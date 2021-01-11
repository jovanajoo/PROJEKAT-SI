
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerRepository
    {
        public List<Customer> GetAllCustomers()
        {
            List<Customer> results = new List<Customer>();
            SqlDataReader sqlDataReader= DBConnection.GetData("SELECT * FROM Customers");

                while (sqlDataReader.Read())
                {
                    Customer c = new Customer();
                    c.CustomerID = sqlDataReader.GetInt32(0);
                    c.Username = sqlDataReader.GetString(1);
                    c.Name = sqlDataReader.GetString(2);
                    c.Email = sqlDataReader.GetString(3);
                    c.City = sqlDataReader.GetString(4);
                    c.Address = sqlDataReader.GetString(5);
                    c.PhoneNumber = sqlDataReader.GetString(6);
                    c.Password = sqlDataReader.GetString(7);

                    results.Add(c);
                }
            DBConnection.CloseConnection();
            return results;
        }
        public int DeleteCustomersById(int Id)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM Customers WHERE Id = {0}", Id));

            DBConnection.CloseConnection();
            return result;
        }
        public int InsertCustomers(Customer c)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Customers VALUES('{0}', '{1}','{2}', '{3}','{4}', '{5}', '{6}')"
                    ,c.Username,c.Name, c.Email, c.City, c.Address, c.PhoneNumber,c.Password));

            DBConnection.CloseConnection();
            return result;
        }
        
        public int UpdateCustomersById(Customer c)
        {
            var result = DBConnection.EditData(string.Format(" UPDATE Customers SET Name = '{0}', Surname = '{1}',Email ='{2}',City ='{3}', Address='{4}', PhoneNumber= '{5}' Password='{6}', WHERE CustomerID={2}"
                , c.Username, c.Name, c.Email, c.City, c.Address, c.PhoneNumber,c.Password));
            
            DBConnection.CloseConnection();
            return result;
            
        }
    }  
}
