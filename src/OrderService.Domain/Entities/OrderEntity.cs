namespace OrderService.Domain.Models;
/// <summary>
/// Order Entity
/// </summary>
public class OrderEntity
{
    /// <summary>
    /// Id Order
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Id Product
    /// </summary>
    //public List<ProductEntity> Products { get; set; }
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

    public OrderEntity(int id, int productId, string description, DateTime? orderDate)
    {
        Id = id;
        ProductId = productId;
        Description = description;
        OrderDate = orderDate;
    }
}