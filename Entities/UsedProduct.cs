using System;
using System.Collections.Generic;
using System.Text;

namespace ProductInfo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        UsedProduct()
        {
        }

        public UsedProduct(DateTime manufactureDate, string name, double price) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + $"(used) ${Price} (Manufacture date: {ManufactureDate})";
        }
    }
}
