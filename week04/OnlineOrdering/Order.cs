class Order
{
    private List<Product> _products;
    private Customer _customer;
    private const double CA_SHIPPING = 7.00;
    private const double INTERNATIONAL_SHIPPING = 35.00;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalProductCost = 0;
        foreach (Product product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        if (_customer.IsInCANADA())
        {
            return totalProductCost + CA_SHIPPING;
        }
        else
        {
            return totalProductCost + INTERNATIONAL_SHIPPING;
        }
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductID()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddressString()}";
    }
}