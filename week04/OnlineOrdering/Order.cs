using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalOrderCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotal();
        }

        if (_customer.IsInUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }
}