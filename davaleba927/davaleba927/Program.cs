using davaleba927;
using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        Electronics electronics = new Electronics();
        Book book = new Book();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Fill Products");
            Console.WriteLine("2. Print Products");
            Console.WriteLine("3. Update Electronics");
            Console.WriteLine("4. Delete Electronics");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    electronics.FillProducts(products);
                    book.FillProducts(products);
                    Console.WriteLine("Products filled successfully.");
                    break;
                case 2:
                    electronics.PrintProducts(products);
                    book.PrintProducts(products);
                    break;
                case 3:
                    Console.Write("Enter product name to update: ");
                    string updateName = Console.ReadLine();
                    Console.Write("Enter new price: ");
                    double newPrice = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter new quantity: ");
                    int newQuantity = Convert.ToInt32(Console.ReadLine());
                    electronics.Update(products, updateName, newPrice, newQuantity);
                    break;
                case 4:
                    Console.Write("Enter product name to delete: ");
                    string deleteName = Console.ReadLine();
                    electronics.Delete(products, deleteName);
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}