using System;
using System.Collections.Generic;

namespace Brincar
{
    class Program
    {
        struct Pessoa
        {
            public string nome;
            public int idade;
            public double peso;
            public double altura;
        }
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa()
            {
                nome = "otavio",
                idade = 37,
                peso = 119,
                altura = 1.83
            };
            Console.WriteLine(p1.nome);
            System.

        }
    }
}
