using System;
using System.Collections.Generic;
using System.Text;

namespace Praticas_Heranca.Entities
{
    class SavingsAccount : Account
    {
        public double IntersRate { get; set; }
        public SavingsAccount()
        {
        }

        public SavingsAccount(double intersRate, int number, string holder, double balance):base(number, holder, balance)
        {
            IntersRate = intersRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * IntersRate;
        }
    }
}
