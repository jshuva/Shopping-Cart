using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class CartIteam
    {
        public decimal Quantity{ get ;  set ;}
        public string Description { get ; private set; }
        public decimal UnitPrice { get ; private set; }
        public decimal Discount { get; private set; }

        public CartIteam(decimal quantity, string description, decimal unitPrice)
        {
            this.Quantity = quantity;
            this.Description = description;
            this.UnitPrice = unitPrice;
        }

        public decimal IteamPrice()
        {
            return Quantity * UnitPrice;
        }

        public void setDiscount(decimal discount)
        {
            Discount = discount;
        }

        public decimal IteamPriceWithDiscount(decimal discount)
        {
            setDiscount(discount);

            decimal calculatedIteamPrice = IteamPrice() - Discount;

            return calculatedIteamPrice > 0 ? calculatedIteamPrice : 0;
        }
    }
}
