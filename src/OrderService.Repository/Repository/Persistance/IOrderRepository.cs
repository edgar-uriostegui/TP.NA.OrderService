using OrderService.Domain.Models;

namespace OrderService.Repository.Repository.Persistance
{
    /// <summary>
    /// Interface for OrderRepository
    /// </summary>
    public interface IOrderRepository
    {
        /// <summary>
        /// Method that retrieves all orders
        /// </summary>
        /// <returns></returns>

        List<OrderEntity> GetAllOrders();
        /// <summary>
        /// Method that retrieve order id
        /// </summary>
        /// <returns></returns>
        int CreateOrder(string description, List<ProductEntity> products, DateTime? orderDate);
    }
}
