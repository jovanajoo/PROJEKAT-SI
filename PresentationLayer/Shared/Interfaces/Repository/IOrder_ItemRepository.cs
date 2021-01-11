using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IOrder_ItemRepository
    {
        List<Order_Item> GetAllOrderItems();
        int DeleteOrderItemsById(int OrderItemID);
        int InsertOrderItems(Order_Item oi);
        int UpdateOrderItemsById(Order_Item oi);
    }
}
