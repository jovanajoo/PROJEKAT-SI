using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderRepository
    {
        public List<Order> GetAllOrders()
        {
            List<Order> results = new List<Order>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Orders";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Order o = new Order();
                    o.OrderID = sqlDataReader.GetInt32(0);
                    o.Order_Date = sqlDataReader.GetString(1);
                    o.Delivery_Date = sqlDataReader.GetString(2);
                  
                    results.Add(o);
                }
            }
            return results;
        }
        public int DeleteOrdersById(int OrderID)
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format("DELETE FROM Orders WHERE OrderID = {0}", OrderID);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();

            }
        }
        public int InsertOrders(Order o)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Orders VALUES('{0}', '{1}')",
                    o.Delivery_Date,o.Delivery_Date);
                return sqlCommand.ExecuteNonQuery();
            }
        }
        public Order GetOrdersById(int OrderID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format(" SELECT * FROM Orders WHERE OrderID = {0}", OrderID);

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                sqlDataReader.Read();
                Order o = new Order();
                o.OrderID = sqlDataReader.GetInt32(0);
                o.Order_Date = sqlDataReader.GetString(1);
                o.Delivery_Date = sqlDataReader.GetString(2);


                return o;

            }

        }
        public int UpdateOrdersById(Order o)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format(" UPDATE Orders SET Order_Date = '{0}', Delivery_Date ='{1}'"
                , o.Order_Date,o.Delivery_Date);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
