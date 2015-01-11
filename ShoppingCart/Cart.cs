using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Cart
    {
        public List<CartIteam> Iteams { get; private set; }

        public Cart()
        {
            this.Iteams = new List<CartIteam>() ;
        }

        public void AddIteams(CartIteam iteam)
        {
            if (Iteams.Contains(iteam))
                return;
            else
                Iteams.Add(iteam);
        }

        public void DeleteIteams(CartIteam iteam)
        {
            Iteams.Remove(iteam);
        }

        public decimal GetTotal(decimal _discount)
        {
            decimal total = 0;
            foreach (CartIteam _iteam in Iteams)
            {
                total = total + _iteam.IteamPriceWithDiscount(_discount);
            }

            return total;
        }
    }
}
