using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsoleApp1
{
    internal class ProductManagementSystem
    {

        static Dictionary<string, int> inventory = new Dictionary<string, int>();

        public void ProductManager()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== Product Inventory Menu ===");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Edit Product Quantity");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. View Inventory");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        EditProduct();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 4:
                        ViewInventory();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void AddProduct()
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter quantity: ");
            int qty = int.Parse(Console.ReadLine()); 

            if (inventory.ContainsKey(name))
            {
                Console.WriteLine("Product already exists! Updating quantity...");
                inventory[name] += qty;
            }
            else
            {
                inventory.Add(name, qty);
            }
            Console.WriteLine("Product added/updated successfully!");
        }

        static void EditProduct()
        {
            Console.Write("Enter product name to edit: ");
            string name = Console.ReadLine();

            if (inventory.ContainsKey(name))
            {
                Console.Write("Enter new quantity: ");
                int qty = int.Parse(Console.ReadLine());
                inventory[name] = qty;
                Console.WriteLine("Quantity updated!");
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        static void DeleteProduct()
        {
            Console.Write("Enter product name to delete: ");
            string name = Console.ReadLine();

            if (inventory.Remove(name))
            {
                Console.WriteLine("Product deleted!");
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        static void ViewInventory()
        {
            Console.WriteLine("\n--- Inventory List ---");
            if (inventory.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            foreach (var item in inventory)
            {
                Console.WriteLine($"Product: {item.Key}, Quantity: {item.Value}");
            }
        }

    }
}
