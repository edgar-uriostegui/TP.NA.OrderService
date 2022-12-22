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
        //public List<Product> Products { get; set; }
        public int ProductId { get; }
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
        /// <param name="productId"></param>
        /// <param name="description"></param>
        /// <param name="orderDate"></param>
        public PostOrderRequest(int id, int productId, string description, DateTime? orderDate)
        {
            Id = id;
            //Products = products;
            ProductId = productId;
            Description = description;
            OrderDate = orderDate;
        }
    }
}
