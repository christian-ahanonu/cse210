using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customers;

    public Order(Customer customer)
    {
        this._customers = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.ProductCost();
        }
        totalCost += customer.LivesInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (var product in _products)
        {
            packingLabel.AppendLine($"Product: {product.Name}, ID: {product.ProductId}");
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{customer.Name}\n{customer.Address.GetFullAddress()}";
    }
}  