using CarRental.Entities;
using CarRental.Services;
using System;
using System.Globalization;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel: ");
            Console.Write("Modelo do carro: ");
            string model = Console.ReadLine();
            Console.Write("Saida (dd/mm/yyyy: ");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Entrada (dd/mm/yyyy: ");
            DateTime fim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            AluguelCarro aluguel = new AluguelCarro(inicio, fim, new Veiculo(model));
            Console.Write("Entre com preço por hora: ");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o preço por dia: ");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AluguelCarro carRental = new AluguelCarro(inicio, fim, new Veiculo(model));
            RentalServices rental = new RentalServices(hora, dia, new BrazilTax());

            rental.ProcessInvoice(carRental);
            Console.WriteLine("Invoice:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
