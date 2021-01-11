using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface InOrder_ItemBusiness
    {
        List<Order_Item> GetAllOrderItems();
        int InsertOrderItems(Order_Item oi);
        int DeleteOrderItemsById(int OrderItemID); 
        Order_Item GetOrderItemsById(int OrderItemID);
        int UpdateOrderItemsById(Order_Item oi);
    }
}
