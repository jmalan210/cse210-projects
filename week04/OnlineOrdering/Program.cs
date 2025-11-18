using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)

    {
        List<Order> orders = new List<Order>();

        //ORDER 1

        List<Product> productList01 = new List<Product>();

        Product cup = new Product("Cup", "001-A", 5.50, 3);
        productList01.Add(cup);
        Product saucer = new Product("Saucer", "001-B", 4.25, 3);
        productList01.Add(saucer);
        Product plate = new Product("Plate", "001-C", 7.75, 6);
        productList01.Add(plate);
        Product bowl = new Product("Bowl", "001-D", 6.35, 6);
        productList01.Add(bowl);
       
        Address address01 = new Address("1234 Main St", "Pocatello", "ID", "USA");

        Customer customer01 = new Customer("Anna George", address01);

        Order order1 = new Order(productList01, customer01);
        orders.Add(order1);

        //ORDER 2

        List<Product> productList02 = new List<Product>();

        Product doll = new Product("Doll", "002-A", 12.50, 1);
        productList02.Add(doll);
        Product ball = new Product("Ball", "002-B", 5.00, 2);
        productList02.Add(ball);
        Product blocks = new Product("Blocks", "002-C", 15.75, 2);
        productList02.Add(blocks);
        Product jumprope = new Product("Jumprope", "002-D", 2.35, 2);
        productList02.Add(jumprope);

        Address address02 = new Address("5678 Oak St", "Montreal", "QC", "Canada");

        Customer customer02 = new Customer("John Jones", address02);

        Order order2 = new Order(productList02, customer02);
        orders.Add(order2);



        foreach (Order order in orders)
        {
            Console.WriteLine("Customer Name:");
            order.DisplayCustomerName();
            Console.WriteLine("Total Cost (including shipping):");
            order.GetTotalCost();
            Console.WriteLine("\nPacking Label:");
            order.PackingLabel();
            Console.WriteLine("\nShipping Label");
            order.ShippingLabel();
            Console.WriteLine("______________________________\n");

        }

    }
}