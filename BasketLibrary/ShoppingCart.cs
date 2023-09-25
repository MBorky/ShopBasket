using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketLibrary;


namespace BasketLibrary
{
    public class ShoppingCart
    {
        private readonly ShopManager InstShopManager;
        private List<Product> basket;
        public ShoppingCart()
        {
            basket = new List<Product>();
        }
        public ShoppingCart(ShopManager instanceRef)
        {
            basket = new List<Product>();
            ShopManager InstShopManager = instanceRef;
        }
        public void AddToBasket(int index, CallbackContainer.Callback callback)
        {
            basket.Add(InstShopManager.Products[index].Clone());
            callback($"Product added:{InstShopManager.Products[index].ProductInfo()}");
            
        }
        public void RemoveFromBasket(int index, CallbackContainer.Callback callback)
        {
            basket.RemoveAt(index);
            callback("Item removed");
        }
        public void RemoveBasket(CallbackContainer.Callback callback)
        {
            basket.Clear();
            callback("Basket cleared");
        }
        public string ShowBasket()
        {
            StringBuilder basketList = new StringBuilder();
            int index = 0;
            if (basket.Count > 0) 
            { 
                return "basket is empty"; 
            }
            foreach (var item in basket)
            {
                basketList.AppendLine($"{index++}. " + item.ProductInfo() + "\n");
            }
            basketList.AppendLine($"Total purchase amount{BasketValue()}");
            return basketList.ToString();
        }
        public decimal BasketValue()
        {
            decimal sum = 0M;
            foreach (var item in basket)
            {
                sum += item.Price;
            }
            return sum;
        }
        public List<Product> BasketCopy()
        {
            List<Product> copy = new List<Product>();
            foreach(Product item in basket)
            {
                copy.Add(item.Clone());
            }
            return copy;

        }

    }
}
