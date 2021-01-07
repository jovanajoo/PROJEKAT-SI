using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Order_ItemRepository
    {
        public List<Order_Item> GetAllOrderItems()
        {
            List<Order_Item> results = new List<Order_Item>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Order_Items";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Order_Item oi = new Order_Item();
                    oi.OrderItemID = sqlDataReader.GetInt32(0);
                    oi.Quantity = sqlDataReader.GetInt32(2);
                    

                    results.Add(oi);
                }
            }
            return results;
        }
        public int DeleteOrderItemsById(int OrderItemID)
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
        public int InsertOrderItems(Order_Item oi)
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
        public Order_Item GetOrderItemsById(int OrderItemsID)
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
                Order_Item oi = new Order_Item();
                oi.OrderItemID = sqlDataReader.GetInt32(0);
                oi.Quantity = sqlDataReader.GetInt32(2);


                return oi;

            }

        }
        public int UpdateOrderItemsById(Order_Item oi)
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
