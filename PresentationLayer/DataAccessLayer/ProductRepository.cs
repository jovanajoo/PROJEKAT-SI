using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductRepository : IProductRepository
    { 
        public List<Product> GetAllProducts()
        {
            List<Product> results = new List<Product>();

            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Products");
            
                while (sqlDataReader.Read())
                {
                    Product p = new Product();
                    p.ProductID = sqlDataReader.GetInt32(0); 
                    p.Name = sqlDataReader.GetString(1);
                    p.Price = sqlDataReader.GetDecimal(2);
                    p.Size = sqlDataReader.GetInt32(3);
                    p.Description = sqlDataReader.GetString(4);
                    long b= sqlDataReader.GetBytes(5, 0, p.ProductImage, 0, Int32.MaxValue);
                    p.CategoryID = sqlDataReader.GetInt32(6);

                results.Add(p);

                }
                DBConnection.CloseConnection();

                return results;
        }
        public int DeleteProductsById(int ProductID)
        {
           var result = DBConnection.EditData(string.Format("DELETE FROM Products WHERE ProductID = {0}", ProductID));

            DBConnection.CloseConnection();
            return result;

            
        }
        public int InsertProducts(Product p)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Products VALUES('{0}', '{1}','{2}', '{3}','{4}','{5}')",
                    p.Name, p.Price, p.Size, p.Description, p.ProductImage, p.CategoryID));
            DBConnection.CloseConnection();
            return result;
                
        }
       
        public int UpdateCProductsById(Product p)
        {
                var result = DBConnection.EditData(string.Format("UPDATE Products SET Name = '{0}', Price ='{1}' ,Size ='{2}' ,Description ='{3}', CategoryID = '{4}' WHERE ProductID = '{5}'"
                , p.Name,p.Price,p.Size,p.Description,p.CategoryID,p.ProductID));

            DBConnection.CloseConnection();
            return result;
        }
    }
}

