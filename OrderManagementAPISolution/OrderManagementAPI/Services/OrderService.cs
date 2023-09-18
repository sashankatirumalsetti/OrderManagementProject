using OrderManagementAPI.Data;
using OrderManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagementAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;

        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public Order? GetOrderById(int id)
        {
            return _context.Orders.FirstOrDefault(order => order.Id == id);
        }

        public Order CreateOrder(Order order)
        {
            

            _context.Orders.Add(order);
            _context.SaveChanges();

            return order;
        }

        public Order UpdateOrder(int id, Order updatedOrder)
        {
            var existingOrder = _context.Orders.FirstOrDefault(order => order.Id == id);

            if (existingOrder == null)
            {
                throw new ArgumentException("Order not found");
            }

            
            existingOrder.OrderNumber = updatedOrder.OrderNumber;
            existingOrder.OrderDate = updatedOrder.OrderDate;
            existingOrder.CustomerName = updatedOrder.CustomerName;
            existingOrder.TotalAmount = updatedOrder.TotalAmount;

            _context.SaveChanges();

            return existingOrder;
        }

        public void DeleteOrder(int id)
        {
            var orderToDelete = _context.Orders.FirstOrDefault(order => order.Id == id);

            if (orderToDelete != null)
            {
                _context.Orders.Remove(orderToDelete);
                _context.SaveChanges();
            }
        }
    }
}
