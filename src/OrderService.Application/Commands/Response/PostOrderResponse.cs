using OrderService.Application.Commands.Models;
using OrderService.Application.Utils;

namespace OrderService.Application.Commands.Response
{
    /// <summary>
    /// Response for PostOrder
    /// </summary>
    public class PostOrderResponse : ResponseBase
    {
        /// <summary>
        /// Orders
        /// </summary>

        public IEnumerable<Order> Orders { get; set; }
    }
}
