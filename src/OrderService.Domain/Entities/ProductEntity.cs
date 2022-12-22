namespace OrderService.Domain.Models;
/// <summary>
/// Order Entity
/// </summary>
public class ProductEntity
{
    /// <summary>
    /// Id Product
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Product name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Product price
    /// </summary>
    public double Price { get; set; }
    /// <summary>
    /// Product quantity
    /// </summary>
    public double Quantity { get; set; }

    /// <summary>
    /// ctor
    /// </summary>

    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="price"></param>
    /// <param name="quantity"></param>

    public ProductEntity(int id, string name, double price, double quantity)
    {
        Id = id;
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}