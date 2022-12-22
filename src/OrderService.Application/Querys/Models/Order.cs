namespace OrderService.Application.Querys.Models
{
    /// <summary>
    /// Model for Order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Id Order
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// Id Product
        /// </summary>
        public int ProductId { get; private set; }
        /// <summary>
        /// Description of order
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// Date of order
        /// </summary>
        public DateTime? OrderDate { get; private set; }

        /// <summary>
        /// ctor
        /// </summary>

        /// <param name="id"></param>
        /// <param name="productId"></param>
        /// <param name="description"></param>
        /// <param name="orderDate"></param>

        public Order(int id, int productId, string description, DateTime? orderDate)
        {
            Id = id;
            ProductId = productId;
            Description = description;
            OrderDate = orderDate;
        }
    }
}
