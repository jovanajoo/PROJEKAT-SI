using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();
        int DeleteOrdersById(int OrderID);
        int InsertOrders(Order o);
        int UpdateOrdersById(Order o);
    }
}
