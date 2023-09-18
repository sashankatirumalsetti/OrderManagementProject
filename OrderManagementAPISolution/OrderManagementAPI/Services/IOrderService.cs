using System.Collections.Generic;
using OrderManagementAPI.Models;

namespace OrderManagementAPI.Services
{
    public interface IOrderService
    {
        // Retrieve a list of all orders
        IEnumerable<Order> GetAllOrders();

        // Retrieve an order by its unique identifier
        Order? GetOrderById(int id);

        // Create a new order
        Order CreateOrder(Order order);

        // Update an existing order by its unique identifier
        Order UpdateOrder(int id, Order updatedOrder);

        // Delete an order by its unique identifier
        void DeleteOrder(int id);
    }
}
