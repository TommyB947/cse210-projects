using System;
using System.Reflection.Metadata.Ecma335;

class Product
{
    private string _name;
    private string _productId;
    private int _quantity;
    private float _price;



    public Product(string productName, string productId, int quantity, float price)
    {
        _name = productName;
        _productId = productId;
        _quantity = quantity;
        _price = price;
    }



    public double ProductPrice()
    {
        double price = Math.Round(_quantity * _price, 2);
        return price;
    }

    public string GetProductText()
    {
        string ProductText = $"{_name} - {_productId}";
        return ProductText;
    }
}