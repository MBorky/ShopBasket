using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    internal class Order
    {
        private DateTimeOffset orderTime;
        private List<Product> orderList;
        public Order()
        {
            orderTime = DateTimeOffset.Now;
            orderList = ShoppingCart.BasketCopy();
        }
    }
}
