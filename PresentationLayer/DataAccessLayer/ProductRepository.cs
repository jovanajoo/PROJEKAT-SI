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

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Products");
            
                while (sqlDataReader.Read())
                {
                    Product p = new Product();
                    p.ProductID = sqlDataReader.GetInt32(0);
                    p.CategoryID = sqlDataReader.GetInt32(1);
                    p.Name = sqlDataReader.GetString(2);
                    p.Price = sqlDataReader.GetDouble(3);
                    p.Size = sqlDataReader.GetInt32(4);
                    p.Description = sqlDataReader.GetString(5);
                    p.b = sqlDataReader.GetBytes(5, 0, p.ProductImage, 0, Int32.MaxValue);

                results.Add(p);

                }
                DBConnection.CloseConnection();

                return results;
        }
        public int DeleteProductsById(int ProductID)
        {
           var result = DBConnection.EditData(string.Format("DELETE FROM Customers WHERE ProductID = {0}", ProductID));

            DBConnection.CloseConnection();
            return result;

            
        }
        public int InsertProducts(Product p)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Products VALUES('{0}', '{1}','{2}', '{3}')",
                    p.Name, p.Price, p.Size, p.Description));
            DBConnection.CloseConnection();
            return result;
                
        }
       
        public int UpdateCProductsById(Product p)
        {
                var result = DBConnection.EditData(string.Format(" UPDATE Products SET Name = '{0}', Price = {1},Size ={2},Description ='{3}'"
                , p.Name,p.Price,p.Size,p.Description));

            DBConnection.CloseConnection();
            return result;
        }
    }
}

