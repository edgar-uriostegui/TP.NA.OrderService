using TP.NA.OrderService.Models;

namespace TP.NA.OrderService.Data
{
    public class OrderStore
    {
        public static List<Order> orders = new List<Order>
        {
            new Order(1, 1, "Order 1", DateTime.Now),
            new Order(2, 2, "Order 2", DateTime.Now),
            new Order(3, 3, "Order 3", DateTime.Now)
        };
    }
}
