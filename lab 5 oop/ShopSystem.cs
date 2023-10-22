using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_oop
{
    internal class ShopSystem
    {
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
        }

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public List<Order> PurchaseHistory { get; set; }
        }

        public class Order
        {
            public List<Product> Products { get; set; }
            public Dictionary<Product, int> ProductQuantities { get; set; }
            public double TotalPrice { get; set; }
            public string Status { get; set; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Створення об'єктів з даними з коду, файлу чи бази даних
                Product product = new Product
                {
                    Name = "Laptop",
                    Price = 999.99,
                    Description = "High-performance laptop with advanced features.",
                    Category = "Electronics"
                };

                User user = new User
                {
                    Username = "user1",
                    Password = "password1",
                    PurchaseHistory = new List<Order>()
                };

                // Додатковий код для зчитування або запису даних

                // Виведення даних в консоль
                Console.WriteLine("Product Name: " + product.Name);
                Console.WriteLine("Product Price: " + product.Price);
                Console.WriteLine("Product Description: " + product.Description);
                Console.WriteLine("Product Category: " + product.Category);

                Console.WriteLine("User Username: " + user.Username);
                Console.WriteLine("User Password: " + user.Password);
                // Додати виведення для інших властивостей об'єкта User

                Console.ReadLine();
            }
        }
    }
}