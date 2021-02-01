using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entities
{
    class AluguelCarro
    {
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }
        public Veiculo Veiculo { get; set; }
        public Invoice Invoice { get; set; }

        public AluguelCarro(DateTime inicio, DateTime final, Veiculo veiculo)
        {
            Inicio = inicio;
            Final = final;
            Veiculo = veiculo;
        }

    }
}
