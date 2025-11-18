public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;

    }

    public double GetSubtotal()
    {
        double subtotal = _price * _quantity;
        return subtotal;
    }

    public string GetPackingLabel()
    {
        string label = $"   Product Name: {_productName}\n   Product ID:{_productID}\n   Quantity: {_quantity}";
        return label;
    }
}