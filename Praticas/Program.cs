using Praticas.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Praticas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.WriteLine("Enter thenumber of employees: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employye #{i} data: ");
                Console.WriteLine("Outsource?: ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.WriteLine("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourceEmployee(name, hour, valuePerHour, additional));
                }
                else
                {
                    list.Add(new Employee(name, hour, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Payments");
            foreach (Employee item in list)
            {
                Console.WriteLine(item.Name + " - $" + item.Payment().ToString());
            }

        }
    }
}
