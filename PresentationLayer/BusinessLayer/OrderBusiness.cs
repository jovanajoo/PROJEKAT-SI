using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class OrderBusiness
    {
        public OrderRepository orderRepository;
        public OrderBusiness()
        {
            this.orderRepository = new OrderRepository();
        }
        
        public List<Order> GetAllOrders()
        {
            return this.orderRepository.GetAllOrders();
        }

        public bool InsertOrders(Order o)
        {
            if (this.orderRepository.InsertOrders(o) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool DeleteOrdersById(int OrderID)
        {
            if (this.orderRepository.DeleteOrdersById(OrderID) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public Order GetOrdersById(int OrderID)
        {
            return this.orderRepository.GetAllOrders().Where(o => o.OrderID == OrderID).First();
        }



        public bool UpdateOrdersById(Order o)
        {
            if (this.orderRepository.updateOrdersById(o) > 0)
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
