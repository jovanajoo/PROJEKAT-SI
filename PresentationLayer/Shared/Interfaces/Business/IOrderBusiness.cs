using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IOrderBusiness
    {
        List<Order> GetAllOrders();
        bool InsertOrders(Order o);
        bool DeleteOrdersById(int OrderID);
        Order GetOrdersById(int OrderID);
        bool UpdateOrdersById(Order o);
        int GetNewOrder();
    }
}
