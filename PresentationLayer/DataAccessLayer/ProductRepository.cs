using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductRepository
    {
        public List<Product> GetAllProducts()
        {
            List<Product> results = new List<Product>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Products";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Product p = new Product();
                    p.ProductID = sqlDataReader.GetInt32(0);
                    p.Name = sqlDataReader.GetString(1);
                    p.Price = sqlDataReader.GetDouble(2);
                    p.Size = sqlDataReader.GetInt32(3);
                    p.Description = sqlDataReader.GetString(4);


                    results.Add(p);
                }
            }
            return results;
        }
        public int DeleteProductsById(int ProductID)
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format("DELETE FROM Customers WHERE ProductID = {0}", ProductID);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();

            }
        }
        public int InsertProducts(Product p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Products VALUES('{0}', '{1}','{2}', '{3}')",
                    p.Name, p.Price, p.Size, p.Description);
                return sqlCommand.ExecuteNonQuery();
            }
        }
        public Product GetProductsById(int ProductID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format(" SELECT * FROM Products WHERE ProductID = {0}", ProductID);

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                sqlDataReader.Read();
                Product p = new Product();
                p.ProductID = sqlDataReader.GetInt32(0);
                p.Name = sqlDataReader.GetString(1);
                p.Price = sqlDataReader.GetDouble(2);
                p.Size = sqlDataReader.GetInt32(3);
                p.Description = sqlDataReader.GetString(4);

                return p;
                
            }

        }
        public int UpdateCProductsById(Product p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format(" UPDATE Products SET Name = '{0}', Price = {1},Size ={2},Description ='{3}'"
                , p.Name,p.Price,p.Size,p.Description);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}

