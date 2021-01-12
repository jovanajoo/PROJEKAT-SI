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
    class OrderBusiness : IOrderBusiness
    {
        private readonly IOrderRepository orderRepository;
        public OrderBusiness(IOrderRepository _orderRepository)
        {
            this.orderRepository = _orderRepository;
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
            if (this.orderRepository.UpdateOrdersById(o) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        int IOrderBusiness.InsertOrders(Order o)
        {
            throw new NotImplementedException();
        }

        int IOrderBusiness.DeleteOrdersById(int OrderID)
        {
            throw new NotImplementedException();
        }

        int IOrderBusiness.UpdateOrdersById(Order o)
        {
            throw new NotImplementedException();
        }
    }
}
