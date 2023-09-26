using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    public class Order
    {
        private DateTimeOffset orderTime;
        private List<Product> orderList;
        private readonly ShoppingCart instCart;
        private decimal orderValue;
        public Order(ShoppingCart instnceRef)
        {
            instCart = instnceRef;
            orderTime = DateTimeOffset.Now;
            orderList = instCart.BasketCopy();
            orderValue = instCart.BasketValue();
            // Removing basket, because order is completed, so basket should be empty
            instCart.RemoveBasket(ConsoleHandlingContainer.DisplayMessage);
            ConsoleHandlingContainer.DisplayMessage($"Order done. Price: {orderValue}");
        }
    }
}
