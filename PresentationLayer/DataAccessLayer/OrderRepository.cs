
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
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetAllOrders()
        {
            List<Order> results = new List<Order>();
            SqlDataReader sqlDataReader=DBConnection.GetData("SELECT * FROM Orders");
                while (sqlDataReader.Read())
                {
                    Order o = new Order();
                    o.OrderID = sqlDataReader.GetInt32(0);
                    o.CustomerID = sqlDataReader.GetInt32(1);
                    o.Order_Date = sqlDataReader.GetDateTime(2);
                    o.Delivery_Date = sqlDataReader.GetDateTime(3);
                  
                    results.Add(o);
                
                }
            DBConnection.CloseConnection();
            return results;
        }
        public int DeleteOrdersById(int OrderID)
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                var result = DBConnection.EditData(string.Format("DELETE FROM Orders WHERE OrderID = {0}", OrderID));

                DBConnection.CloseConnection();
                return result;
            }
        }
        public int InsertOrders(Order o)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {       
                var result = DBConnection.EditData(string.Format("INSERT INTO Orders VALUES('{0}', '{1}', '{2}')",
                    o.Order_Date,o.Delivery_Date, o.CustomerID));
                DBConnection.CloseConnection();
                return result;
            }
        }
        
        public int UpdateOrdersById(Order o)
        {
            var result = DBConnection.EditData(string.Format(" UPDATE Orders SET Order_Date = '{0}', Delivery_Date ='{1}'"
                , o.Order_Date,o.Delivery_Date));

            DBConnection.CloseConnection();

            return result;
        }
        public int GetNewOrder()
        {
            SqlDataReader sqlDataReader = DBConnection.GetData(string.Format("SELECT IDENT_CURRENT('Orders')"));

            sqlDataReader.Read();
            var result = Convert.ToInt32(sqlDataReader[0]);
            DBConnection.CloseConnection();
            return result;
        }
       
    }
}
