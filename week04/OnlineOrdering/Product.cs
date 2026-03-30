public class Product
{
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, int productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetProductPrice()
    {
        decimal Price = _price * _quantity;
        return Price;
    }

    public string GetLabel()
    {
        return $"{_name} (ID: {_productId})";
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"{GetLabel()} - {_price}$, {_quantity} item(s) Total = {GetProductPrice()}$");
    }
}                                                         