using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ServicoEmprestimo.Entities
{
    class Installment
    {
        public DateTime dueDate { get; set; }
        public double amount { get; private set; }

        public Installment(DateTime date, double amount)
        {
            dueDate = date;
            this.amount = amount;
        }
        public override string ToString()
        {
            return dueDate.ToString("dd/MM/yyyy")
                + " - "
                + amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
