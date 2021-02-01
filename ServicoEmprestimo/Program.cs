using ServicoEmprestimo.Entities;
using ServicoEmprestimo.Services;
using System;
using System.Globalization;

namespace ServicoEmprestimo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date dd/mm/yyyy: ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contrato myContract = new Contrato(contractNumber, contractDate, contractValue);

            ContractServices contractService = new ContractServices(new PaypalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("Installments: ");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
