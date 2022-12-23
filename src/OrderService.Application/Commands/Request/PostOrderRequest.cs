using OrderService.Application.Commands.Models;
using OrderService.Domain.Models;

namespace OrderService.Application.Commands.Request
{
    /// <summary>
    /// Request for Postorder
    /// </summary>
    public class PostOrderRequest
    {
        /// <summary>
        /// Id Order
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// Id Product
        /// </summary>
        public List<ProductEntity> Products { get; set; }
        /// <summary>
        /// Description of order
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Date of order
        /// </summary>
        public DateTime? OrderDate { get; }

        /// <summary>
        /// ctor
        /// </summary>

        /// <param name="id"></param>
        /// <param name="products"></param>
        /// <param name="description"></param>
        /// <param name="orderDate"></param>
        public PostOrderRequest(int id, List<ProductEntity> products, string description, DateTime? orderDate)
        {
            Id = id;
            Products = products;
            Description = description;
            OrderDate = orderDate;
        }
    }
}
