using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Order_ItemsBusiness
    {
        public Order_ItemsRepository order_ItemsRepository;
        public Order_ItemsBusiness()
        {
            this.order_ItemsRepository = new Order_ItemsRepository();
        }

        public List<Order_Items> getAllOrderItems()
        {
            return this.order_ItemsRepository.GetAllOrderItems();
        }



        public bool InsertOrderItems(Order_Items oi)
        {
            if (this.order_ItemsRepository.InsertOrderItems(oi) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool deleteOrderItemsById(int OrderItemID)
        {
            if (this.order_ItemsRepository.deleteOrderItemsById(OrderItemID) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public Order_Items getOrderItemsById(int OrderItemsID)
        {
            return this.order_ItemsRepository.GetAllOrderItems().Where(oi => oi.OrderItemID == OrderItemsID).First();
        }



        public bool updateOrderItemsById(Order_Items oi)
        {
            if (this.order_ItemsRepository.updateOrderItemsById(oi) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
