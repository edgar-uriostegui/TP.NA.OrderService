using OrderService.Application.Querys.Models;
using OrderService.Application.Utils;

namespace OrderService.Application.Querys.Response
{
    /// <summary>
    /// Response for GetOrder
    /// </summary>
    public class GetOrderResponse : ResponseBase
    {
        /// <summary>
        /// List of orders
        /// </summary>
        public IEnumerable<Order> Orders { get; set; }
    }
}
