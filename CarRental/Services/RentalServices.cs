using System;
using System.Collections.Generic;
using System.Text;
using CarRental.Entities;


namespace CarRental.Services
{
    class RentalServices
    {
        public double PrecoPorHora { get;private set; }
        public double PrecoPorDia { get; private set; }

        private ITaxService _taxServico;

        public RentalServices(double precoPorHora, double precoPorDia, ITaxService tax)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxServico = tax;
        }
        public void ProcessInvoice (AluguelCarro carRental)
        {
            TimeSpan duration = carRental.Final.Subtract(carRental.Inicio);
            double basciPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basciPayment = PrecoPorHora * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basciPayment = PrecoPorDia * Math.Ceiling(duration.TotalDays);
            }
            double tax = _taxServico.Tax(basciPayment);
            carRental.Invoice = new Invoice(basciPayment, tax);
        }
    }
}
