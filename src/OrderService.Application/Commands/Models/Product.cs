namespace OrderService.Application.Commands.Models
{
    public class Product
    {
        /// <summary>
        /// Id Product
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name Product
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Proce of Products
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Quantity of Products
        /// </summary>
        public double Quantity { get; set; }

        /// <summary>
        /// ctor
        /// </summary>

        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="quantity"></param>

        public Product(int id, string name, double price, double quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}