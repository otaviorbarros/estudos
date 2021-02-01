using System.Globalization;
namespace CarRental.Entities
{
    class Invoice
    {
        public double basicPayment { get; set; }
        public double tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            this.basicPayment = basicPayment;
            this.tax = tax;
        }
        public double TotalPayment
        {
            get { return basicPayment + tax; }
        }
        public override string ToString()
        {
            return "Basic Payment: "
                + basicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

