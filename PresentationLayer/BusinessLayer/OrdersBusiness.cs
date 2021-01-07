using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class OrdersBusiness
    {
        public OrderRepository ordersRepository;
        public OrdersBusiness()
        {
            this.ordersRepository = new OrderRepository();
        }

        public List<Order> getAllOrders()
        {
            return this.ordersRepository.GetAllOrders();
        }



        public bool InsertOrders(Order o)
        {
            if (this.ordersRepository.InsertOrders(o) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool deleteOrdersById(int OrderID)
        {
            if (this.ordersRepository.deleteOrdersById(OrderID) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public Order getOrdersById(int OrderID)
        {
            return this.ordersRepository.GetAllOrders().Where(o => o.OrderID == OrderID).First();
        }



        public bool updateOrdersById(Order o)
        {
            if (this.ordersRepository.updateOrdersById(o) > 0)
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
