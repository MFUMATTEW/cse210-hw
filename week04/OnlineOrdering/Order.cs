public class Order
{
    private Customer _customers;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customers = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (Product p in _products)
        {
            total += p.GetProductPrice();
        }

        if(_customers.Country())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in _products)
        {
            label += p.GetLabel() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: \n{_customers.GetName()}\n{_customers.GetAddress().GetFullAddress()}";
    }

}

