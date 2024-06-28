using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba927
{
  class Electronics : Product
    {
        private string productName;
        private double price;
        private int quantity;

        public override string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public override double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Electronics() { }

        public Electronics(string productName, double price, int quantity)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }

        public override void FillProducts(List<Product> products)
        {
            products.Add(new Electronics("Laptop", 1200.50, 10));
            products.Add(new Electronics("Smartphone", 800.00, 20));
        }

        public override void PrintProducts(List<Product> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i] is Electronics)
                {
                    Console.WriteLine("Electronics - Name: " + products[i].ProductName + ", Price: " + products[i].Price + ", Quantity: " + products[i].Quantity);
                }
            }
        }

        public void Update(List<Product> products, string productName, double newPrice, int newQuantity)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductName == productName && products[i] is Electronics)
                {
                    products[i].Price = newPrice;
                    products[i].Quantity = newQuantity;
                    Console.WriteLine("Product updated successfully.");
                    return;
                }
            }
            Console.WriteLine("Product not found.");
        }

        public void Delete(List<Product> products, string productName)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductName == productName && products[i] is Electronics)
                {
                    products.RemoveAt(i);
                    Console.WriteLine("Product deleted successfully.");
                    return;
                }
            }
            Console.WriteLine("Product not found.");
        }
    }
}
