public class Product
{
    public int ProductId { get; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public Product(int id, string name, int quantity, decimal price)
    {
        ProductId = id;
        ProductName = name;
        Quantity = quantity;
        Price = price;
    }
}
