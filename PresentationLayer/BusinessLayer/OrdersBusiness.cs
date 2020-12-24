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
        public OrdersRepository ordersRepository;
        public OrdersBusiness()
        {
            this.ordersRepository = new OrdersRepository();
        }

        public List<Orders> getAllOrders()
        {
            return this.ordersRepository.GetAllOrders();
        }



        public bool InsertOrders(Orders o)
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



        public Orders getOrdersById(int OrderID)
        {
            return this.ordersRepository.GetAllOrders().Where(o => o.OrderID == OrderID).First();
        }



        public bool updateOrdersById(Orders o)
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
