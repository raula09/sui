using System;
using System.Collections.Generic;


public abstract class Product
{
    public abstract string ProductName { get; set; }
    public abstract double Price { get; set; }
    public abstract int Quantity { get; set; }

    public abstract void FillProducts(List<Product> products);
    public abstract void PrintProducts(List<Product> products);
}
