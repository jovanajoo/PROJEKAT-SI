using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomersRepository
    {
        public List<Customers> GetAllCustomers()
        {
            List<Customers> results = new List<Customers>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Customers";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Customers c = new Customers();
                    c.CustomerID = sqlDataReader.GetInt32(0);
                    c.Name = sqlDataReader.GetString(1);
                    c.Surname = sqlDataReader.GetString(2);
                    c.Email = sqlDataReader.GetString(3);
                    c.City = sqlDataReader.GetString(4);
                    c.Address = sqlDataReader.GetString(5);
                    c.PhoneNumber = sqlDataReader.GetString(6);

                    results.Add(c);
                }
            }
            return results;
        }
        public int deleteCustomersById(int Id)
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format("DELETE FROM Customers WHERE Id = {0}", Id);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();

            }
        }
        public int InsertCustomers(Customers c)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Customers VALUES('{0}', '{1}','{2}', '{3}','{4}', '{5}')",
                    c.Name, c.Surname, c.Email, c.City, c.Address, c.PhoneNumber);
                return sqlCommand.ExecuteNonQuery();
            }
        }
        public Customers getCustomersById(int Id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format(" SELECT * FROM Customers WHERE Id = {0}", Id);

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                sqlDataReader.Read();
                Customers c = new Customers();
                c.CustomerID = sqlDataReader.GetInt32(0);
                c.Name = sqlDataReader.GetString(1);
                c.Surname = sqlDataReader.GetString(2);
                c.Email = sqlDataReader.GetString(3);
                c.City = sqlDataReader.GetString(4);
                c.Address = sqlDataReader.GetString(5);
                c.PhoneNumber = sqlDataReader.GetString(6);

                return c;
            }
        }
        public int updateCustomersById(Customers c)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format(" UPDATE Customers SET Name = '{0}', Surname = '{1}',Email ='{2}',City ='{3}', Address='{4}', PhoneNumber= '{5}', WHERE CustomerID={2}"
                , c.Name, c.Surname, c.Email, c.City, c.Address, c.PhoneNumber);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
       
}
