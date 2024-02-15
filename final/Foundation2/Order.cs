public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor to initialize the order with a customer.
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    // Method to add a product to the order.
    public void AddProduct(Product product)
    {
        _products.Add(product); // Add the product to the list of products.
    }

    // Method to calculate the total cost of the order.
    public double TotalOrderCost()
    {   
        double total = 0;  // Initialize the total cost to zero.

        // Iterate over each product in the order and sum up their costs.
        foreach (var product in _products)
        {
            total += product.TotalProductCost();  // Add the cost of the product to the total.
        }

        // Add the shipping cost based on the customer's location.
        if (_customer.LiveInUsa())
        {
            total += 5;  // Shipping cost for customers in the USA.
        }

        else
        {
            total += 35; // Shipping cost for customers outside the USA.
        }

        return total;  // Return the total cost of the order.
    }

    public string PackingLabel()
    {
        // Initialize the packing label.
        string packing = $"Packing label for {_customer.Name}:\n";

        // Add information about each product in the order to the packing label.
        foreach (var product in _products)
        {
            packing += $"Product ID: {product.ProductId}\n";
        }

        return packing;  // Return the packing label.
    }

    public string ShippingLabel()
    {
         // Initialize the shipping label.
        string shipping = $"Shipping label for {_customer.Name}:\n";
        
        // Add information about the customer's address to the shipping label.
        shipping += _customer.Address.DisplayAddress();

        return shipping;  // Return the shipping label.
    }
}