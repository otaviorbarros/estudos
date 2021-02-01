using System;
using System.Collections.Generic;
using System.Text;
using ServicoEmprestimo.Entities;

namespace ServicoEmprestimo.Services
{
    class ContractServices
    {
        private IOnlinePaymentService _onlinePaymentService;
        public ContractServices(IOnlinePaymentService onl)
        {
            _onlinePaymentService = onl;
        }
        public void ProcessContract(Contrato contract, int months)
        {
            double basicQuota = contract.totalValue / months;
            for (int i = 1; i < months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updateQuota + _onlinePaymentService.PaymentFee(updateQuota);
                contract.AddList(new Installment(date, fullQuota));
            }
        }
    }
}
