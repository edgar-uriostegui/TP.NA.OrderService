namespace OrderService.Application.Commands.Models
{
    public class Order
    {
        /// <summary>
        /// Id Order
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// Id Product
        /// </summary>
        public List<Product> Products { get; }
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

        public Order(int id, List<Product> products, string description, DateTime? orderDate)
        {
            Id = id;
            Products = products;
            Description = description;
            OrderDate = orderDate;
        }
    }
}