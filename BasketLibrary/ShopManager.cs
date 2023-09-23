using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    public class ShopManager
    {
        public List<Product> Products { get; private set; }
        public ShopManager() 
        {
            Products = new List<Product>();
            
        }

        public void AddProduct(Product item) 
        {
            Products.Add(item);
        }
      
        public string ProductList()
        {
            StringBuilder produtList = new StringBuilder();
            foreach (var item in Products)
            {
                produtList.AppendLine(item.ProductInfo() + "\n");
            }
            return produtList.ToString();
        }
        public string ProductList<T>() where T : Product
        {
            StringBuilder productList = new StringBuilder();
            foreach (var item in Products.OfType<T>())
            {
                productList.AppendLine(item.ProductInfo() + "\n");
            }
            return productList.ToString();
        }

    }

}
