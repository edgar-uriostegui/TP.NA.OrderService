using OrderService.Domain.Models;
using OrderService.Repository.Repository.Persistance;

namespace OrderService.Repository.Repository.Core
{
    /// <summary>
    /// Repository for Orders
    /// </summary>
    
    public class OrderRepository : IOrderRepository
    {
        /// <summary>
        /// Method that retrieves all orders
        /// </summary>
        /// <returns></returns>
        
        public List<OrderEntity> GetAllOrders()
        {
            return orders;
        }

        /// <summary>
        /// Method that retrieves order id
        /// </summary>
        /// <returns></returns>
        public OrderEntity CreateOrder(OrderEntity order)
        {
            order.Id = orders.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            orders.Add(order);

            return order;
        }

        public static List<OrderEntity> orders = new()
        {
            //new OrderEntity(1, new List<ProductEntity> prod = new() {1,"Product 1", 10, 2}, "Order 1", DateTime.Now)
            new OrderEntity(1, 1, "Order 1", DateTime.Now),
            new OrderEntity(2, 2, "Order 2", DateTime.Now),
            new OrderEntity(3, 3, "Order 3", DateTime.Now)
        };
    }
}