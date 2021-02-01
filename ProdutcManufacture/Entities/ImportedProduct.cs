using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProdutcManufacture.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct() { }

        public ImportedProduct(double customsFee, string name, double price) :base(name, price)
        {
            CustomsFee = customsFee;
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string priceTag()
        {
            return base.priceTag() + CustomsFee;
        }
        public override string ToString()
        {
            return Name + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
