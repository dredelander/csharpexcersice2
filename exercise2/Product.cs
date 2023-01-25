namespace exercise2;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }

    public Product()
    {
        Name = string.Empty;
        Description = string.Empty;
    }

}