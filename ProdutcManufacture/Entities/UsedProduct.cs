using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProdutcManufacture.Entities
{
    class UsedProduct : Product
    {
        public DateTime Date { get; set; }
        public UsedProduct() { }

        public UsedProduct(DateTime date, string name, double price) : base(name, price)
        {
            Date = date;
        }
        public override string priceTag()
        {
            return base.priceTag() + Date.ToString();

        }
        public override string ToString()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + Date.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
