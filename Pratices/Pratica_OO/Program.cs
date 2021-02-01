using Pratica_OO.Entities;
using Pratica_OO.Enum;
using System;
using System.Globalization;

namespace Pratica_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime dateBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = (OrderStatus)int.Parse(Console.ReadLine());
            Client c1 = new Client(name, email, dateBirth);
            Order order = new Order(DateTime.Now, status, c1);
            Console.Write("How many items to this order? ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Name: ");
                string prod = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
               
                Product prod1 = new Product(prod, price);
                int qtd = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(qtd, price, prod1);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY");
            Console.WriteLine(order);
            Console.ReadLine();

        }
    }
}
