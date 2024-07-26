using System;

public class Product
{
    private string _name;
    private string _productId;
    private int _price;
    private int _quantity;

    public Product(string name, string producId, int price, int quantity)
    {
        _name = name;
        _productId = producId;
        _price = price;
        _quantity = quantity;
    }

    public string Name => _name;
    public string ProductId => _productId;
    public double Price => _price;
    public int Quantity => _quantity;

    public int ProductCost()
    {
        return _price * _quantity;
    }
}