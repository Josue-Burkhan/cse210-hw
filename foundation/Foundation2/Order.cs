public class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.GetTotalCost();
        }

        if (customer.IsInUSA())
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
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}
