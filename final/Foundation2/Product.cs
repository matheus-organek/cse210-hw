public class Product
{
    // Member variables to store product information.
    private string _nameProduct;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor to initialize product properties.
    public Product(string nameProduct, string productId, double price, int quantity)
    {
        _nameProduct = nameProduct;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Method to calculate the total cost of the product.
    public double TotalProductCost()
    {
        // Calculate the total cost by multiplying the price per unit by the quantity.
        double total = _quantity * _price;

        return total; // Return the total cost of the product.
    }

    // Getters and setters for the _nameProduct variable.
    public string NameProduct
    {
        get { return _nameProduct; }
        set { _nameProduct = value; }
    }

    // Getters and setters for the _productId variable.
    public string ProductId
    {
        get { return _productId; }
        set { _productId = value; }
    }

    // Getters and setters for the _price variable.
    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }

    // Getters and setters for the _quantity variable.
    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }
}