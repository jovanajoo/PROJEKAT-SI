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
        int InsertOrders(Order o);
        int DeleteOrdersById(int OrderID);
        Order GetOrdersById(int OrderID);
        int UpdateOrdersById(Order o);
    }
}
