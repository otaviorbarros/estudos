using System;
using System.Collections.Generic;

namespace Estudos
{
    class Program
    {
        enum aprender { Criar=1, Alterar, Excluir, Consultar}
        static void Main(string[] args)
        {
            Console.WriteLine("1-Criar\n2-Alterar\n3-Excluir\n4-Consultar");
            int n = int.Parse(Console.ReadLine());
            aprender teste = (aprender)n;
            switch (n)
            {
                case 1:
                    Console.WriteLine("Criar algo");
                    break;
                case 2:
                    Console.WriteLine("Altere algo");
                    break;
                case 3:
                    Console.WriteLine("Exlua algo");
                    break;
                case 4:
                    Console.WriteLine("Consulte algo");
                    break;
                default:
                    Console.WriteLine("Numero invalido");
                    break;
            }
            return;
        }
    }
}
