using DataAccessLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Order_ItemBusiness : IOrder_ItemBusiness
    {
        private readonly IOrder_ItemRepository order_ItemRepository;
        public Order_ItemBusiness(IOrder_ItemRepository _order_ItemRepository)
        {
            this.order_ItemRepository = _order_ItemRepository;
        }

        public List<Order_Item> GetAllOrderItems()
        {
            return this.order_ItemRepository.GetAllOrderItems();
        }

        public bool InsertOrderItems(Order_Item oi)
        {
            if (this.order_ItemRepository.InsertOrderItems(oi) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool DeleteOrderItemsById(int OrderItemID)
        {
            if (this.order_ItemRepository.DeleteOrderItemsById(OrderItemID) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public Order_Item GetOrderItemsById(int OrderItemID)
        {
            return this.order_ItemRepository.GetAllOrderItems().Where(oi => oi.OrderItemID == OrderItemID).First();
        }



        public bool UpdateOrderItemsById(Order_Item oi)
        {
            if (this.order_ItemRepository.UpdateOrderItemsById(oi) > 0)
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
