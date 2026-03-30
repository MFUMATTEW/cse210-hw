using System;

class Program
{
    static void Main(string[] args)
    {
        Address location_x = new Address("192 Boulevard Triomphale", "Libreville", "Estuaire", "Gabon");
        Address location_y = new Address("556 Kwaku street", "Accra", "Greater Accra", "Ghana");

        Customer client_x = new Customer(location_x, "Flavien Mabouba");
        Customer client_y = new Customer(location_y, "Kwaku Frimpong");

        Product x = new Product("Laptop", 1058, 350.00m, 3);
        Product y = new Product("Tablet", 5648, 36.56m, 4);
        Product z = new Product("Phone", 6983, 36.52m, 2);

        Order order_x = new Order(client_x);
        order_x.AddProduct(x);

        Order order_y = new Order(client_y);
        order_y.AddProduct(y);
        order_y.AddProduct(z);

        Console.WriteLine(order_x.GetPackingLabel());
        Console.WriteLine(order_x.GetShippingLabel());
        Console.WriteLine($"Order_x Total Cost: {order_x.GetTotalCost()}");

        Console.WriteLine("");
        
        Console.WriteLine(order_y.GetPackingLabel());
        Console.WriteLine(order_y.GetShippingLabel());
        Console.WriteLine($"Order_y Total Cost: {order_y.GetTotalCost()}");

    }
}