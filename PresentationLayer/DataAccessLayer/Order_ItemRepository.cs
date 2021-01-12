
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
    public class Order_ItemRepository : IOrder_ItemRepository
    {
        public List<Order_Item> GetAllOrderItems()
        {
            List<Order_Item> results = new List<Order_Item>();
            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Order_Items");

                while (sqlDataReader.Read())
                {
                    Order_Item oi = new Order_Item();
                    oi.OrderItemID = sqlDataReader.GetInt32(0);
                    oi.OrderID = sqlDataReader.GetInt32(1);
                    oi.ProductID = sqlDataReader.GetInt32(2);
                    oi.Quantity = sqlDataReader.GetInt32(3);
                    

                    results.Add(oi);
                }
            DBConnection.CloseConnection();
            return results;
        }
        public int DeleteOrderItemsById(int OrderItemID)
        {
            var result = DBConnection.EditData(string.Format("DELETE FROM Order_Items WHERE OrderItemID = {0}", OrderItemID));

            DBConnection.CloseConnection();
            return result;

        }
        public int InsertOrderItems(Order_Item oi)
        {
            var result = DBConnection.EditData(string.Format("INSERT INTO Order_Items VALUES({0})",oi.Quantity));
            DBConnection.CloseConnection();
            return result;
            
        }
        
        public int UpdateOrderItemsById(Order_Item oi)
        {
           var result = DBConnection.EditData(string.Format(" UPDATE Order_Items SET Quantity={0}",oi.Quantity));

            DBConnection.CloseConnection();
            return result;
            
        }
    }
}
