using System;
using System.Collections.Generic;
using System.Text;

namespace Pratica_OO.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Emai { get; set; }
        public DateTime BirthDate { get; set; }
        public Client() { }

        public Client(string name, string emai, DateTime birthDate)
        {
            Name = name;
            Emai = emai;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            return Name + ", " + BirthDate.ToString("dd/MM/yyyy") + " - " + Emai;
        }
    }
}
