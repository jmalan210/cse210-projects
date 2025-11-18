using System.ComponentModel.Design.Serialization;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _customer = customer;
        _products = products;

    }

    public void  GetTotalCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {

            double subtotal = p.GetSubtotal();
            total += subtotal;
        }
        double shipping = 0;
        if (_customer.Domestic() == true)
        {
            shipping = 5.00;
        }
        else
        {
            shipping = 35.00;
        }

        double grandTotal = total + shipping;

      Console.WriteLine($"${grandTotal:F2}");

    }
    
    public void DisplayCustomerName()
    {
      Console.WriteLine(_customer.DisplayCustomerName());
       
    }

    public void PackingLabel()
    {
        foreach (Product p in _products)
        {
            Console.WriteLine(p.GetPackingLabel());

        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine(_customer.DisplayCustomerName());
        Console.WriteLine(_customer.DisplayCustomerAddress());
       
    }
}