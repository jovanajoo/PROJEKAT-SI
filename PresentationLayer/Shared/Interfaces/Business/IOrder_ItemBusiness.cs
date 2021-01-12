using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
   public interface IOrder_ItemBusiness
    {
        List<Order_Item> GetAllOrderItems();
        bool InsertOrderItems(Order_Item oi);
        bool DeleteOrderItemsById(int OrderItemID);
        Order_Item GetOrderItemsById(int OrderItemID);
        bool UpdateOrderItemsById(Order_Item oi);
    }
}
