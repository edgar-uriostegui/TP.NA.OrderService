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

        public int CreateOrder(string description, List<ProductEntity> products, DateTime? orderDate)
        {
            int idOrder = orders.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            orders.Add(new OrderEntity(idOrder, products, description, orderDate));
            return idOrder;
        }

        public static List<OrderEntity> orders = new()
        {
            new OrderEntity(1, new List<ProductEntity> { new ProductEntity(1, "Product 1", 10, 2), new ProductEntity(2, "Product 2", 150, 3) }, "Order 1", DateTime.Now),
            new OrderEntity(2, new List<ProductEntity> { new ProductEntity(1, "Product 1", 24, 12), new ProductEntity(2, "Product 2", 53, 5) }, "Order 2", DateTime.Now)
        };
    }
}