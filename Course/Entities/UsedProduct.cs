using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufaturateDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufaturateDate)
            : base(name, price)
        {
            ManufaturateDate = manufaturateDate;
        }

        public override string priceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacturate date: " + ManufaturateDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
