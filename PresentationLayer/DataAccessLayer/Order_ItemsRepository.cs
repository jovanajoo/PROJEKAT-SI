using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Order_ItemsRepository
    {
        public List<Order_Items> GetAllOrderItems()
        {
            List<Order_Items> results = new List<Order_Items>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Order_Items";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Order_Items oi = new Order_Items();
                    oi.OrderItemID = sqlDataReader.GetInt32(0);
                    oi.Quantity = sqlDataReader.GetInt32(2);
                    

                    results.Add(oi);
                }
            }
            return results;
        }
        public int deleteOrderItemsById(int OrderItemID)
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format("DELETE FROM Order_Items WHERE OrderItemID = {0}", OrderItemID);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();

            }
        }
        public int InsertOrderItems(Order_Items oi)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Order_Items VALUES({0})",oi.Quantity);
                return sqlCommand.ExecuteNonQuery();
            }
        }
        public Order_Items getOrderItemsById(int OrderItemsID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format(" SELECT * FROM Order_Items WHERE OrderItemsID = {0}", OrderItemsID);

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                sqlDataReader.Read();
                Order_Items oi = new Order_Items();
                oi.OrderItemID = sqlDataReader.GetInt32(0);
                oi.Quantity = sqlDataReader.GetInt32(2);


                return oi;

            }

        }
        public int updateOrderItemsById(Order_Items oi)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                string.Format(" UPDATE Order_Items SET Quantity={0}",oi.Quantity);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
