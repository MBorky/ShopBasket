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
        public ShoppingCart(ShopManager instance)
        {
            basket = new List<Product>();
            ShopManager InstShopManager = instance;
        }
        public void AddToBasket(int index)
        {
            basket.Add(InstShopManager.Products[index].Clone());
        }
        public void RemoveFromBasket(int index)
        {
            basket.RemoveAt(index);
        }
        public void RemoveBasket()
        {
            basket.Clear();
        }
        public string ShowBasket()
        {
            StringBuilder basketList = new StringBuilder();
            foreach (var item in basket)
            {
                basketList.AppendLine(item.ProductInfo() + "\n");
            }
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
