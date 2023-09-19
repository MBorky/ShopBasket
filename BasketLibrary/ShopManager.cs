using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    internal class ShopManager
    {
        private List<Product> products;
        public ShopManager() 
        {
            products = new List<Product>();
        }

        public void AddProduct(Product item) 
        {
            products.Add(item);
        }
      
        public string ProductList()
        {
            StringBuilder produtList = new StringBuilder();
            foreach (var item in products)
            {
                produtList.AppendLine(item.ProductInfo() + "\n");
            }
            return produtList.ToString();
        }
        public string ProductList<T>() where T : Product
        {
            StringBuilder productList = new StringBuilder();
            foreach (var item in products.OfType<T>())
            {
                productList.AppendLine(item.ProductInfo() + "\n");
            }
            return productList.ToString();
        }

    }

}
