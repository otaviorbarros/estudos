using System;
using System.Collections.Generic;
using System.Text;

namespace ServicoEmprestimo.Entities
{
    class Contrato
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double totalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contrato(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            this.totalValue = totalValue;
            Installments = new List<Installment>();
        }
        public void AddList(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
