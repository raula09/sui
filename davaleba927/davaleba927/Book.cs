using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace davaleba927
{
    class Book : Product
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

        public Book() { }

        public Book(string productName, double price, int quantity)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }

        public override void FillProducts(List<Product> products)
        {
            products.Add(new Book("C# Programming", 45.99, 15));
            products.Add(new Book("Introduction to Algorithms", 89.99, 5));
        }

        public override void PrintProducts(List<Product> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i] is Book)
                {
                    Console.WriteLine("Book - Name: " + products[i].ProductName + ", Price: " + products[i].Price + ", Quantity: " + products[i].Quantity);
                }
            }
        }
    }

}
