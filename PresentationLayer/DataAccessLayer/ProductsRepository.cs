using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductsRepository
    {
        public List<Products> GetAllProducts()
        {
            List<Products> results = new List<Products>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Products";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Products p = new Products();
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
        public int deleteProductsById(int ProductID)
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
        public int InsertProducts(Products p)
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
        public Products getProductsById(int ProductID)
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
                Products p = new Products();
                p.ProductID = sqlDataReader.GetInt32(0);
                p.Name = sqlDataReader.GetString(1);
                p.Price = sqlDataReader.GetDouble(2);
                p.Size = sqlDataReader.GetInt32(3);
                p.Description = sqlDataReader.GetString(4);

                return p;
                
            }

        }
        public int updateCProductsById(Products p)
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

