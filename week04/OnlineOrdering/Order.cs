using System;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices.Marshalling;

class Order
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

    public double OrderCost()
    {
        double total = 0;
        for (int i = 0; i < _products.Count(); i++)
        {
            total += _products[i].ProductPrice();
            //Console.WriteLine(total);
        }
        
        if (!_customer.LiveInUS())
        {
            total += 35;
        }

        else
        {
            total += 5;
        }

        //Console.WriteLine(total);
        return Math.Round(total, 2);
    }

    public string ShippingLabel()
    {
        string shippingLabel;
        shippingLabel = _customer.GetCustomerText();

        return shippingLabel;
    }

    public string PackingLabel()
    {
        string packingLabel = "Packing Label: " + Environment.NewLine;
        for (int i = 0; i < _products.Count(); i++)
        {
            packingLabel += $"Product {i + 1}: {_products[i].GetProductText()}" + Environment.NewLine;
            //Console.WriteLine($"{packingLabel}");
        }
        return packingLabel;
    }
}