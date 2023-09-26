using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    public class ShopManager
    {
        public List<Product> Products { get; private set; }
        public ShopManager() 
        {
            Products = new List<Product>()
            {
            new Clothing("Jacket", 1454.82m, "L", "Red"),
            new Clothing("Trousers", 445.32m, "XL", "Blue"),
            new Clothing("Tunic", 403.16m, "M", "White"),
            new Clothing("Hoodie", 368.05m, "XL", "Black"),
            new Clothing("T-shirt", 108.22m, "XL", "Blue"),
            new Electronics("Xiaomi", 1236.95m, "Smartphone", "Yellow"),
            new Electronics("Galaxy buds", 341.38m, "Headphone", "Yellow"),
            new Electronics("Koss kc45", 311.25m, "Headphone", "White"),
            new Electronics("Audio Labs", 428.5m, "Headphone", "Green"),
            new Electronics("Gopro", 477.57m, "Camera", "White")
        };
            
        }
        public void AddProduct(Product item) 
        {
            Products.Add(item);
        }
      
        public string ProductList()
        {
            StringBuilder productList = new StringBuilder();
            int index = 1;
            if (Products.Count <= 0) 
            {
                return "There is no products";
            }
            foreach (var item in Products)
            {
                productList.AppendLine($"Art.Number: {index++} " + item.ProductInfo() + "\n");
            }
            return productList.ToString();
        }
        public string ProductList<T>() where T : Product
        {
            StringBuilder productList = new StringBuilder();
            /*foreach (var item in Products.OfType<T>())
            {
                productList.AppendLine(item.ProductInfo() + "\n");
            }*/
            if (Products.Count <= 0)
            {
                return "There is no products";
            }
            //foreach (var item in Products) 
            for(int i = 0; i < Products.Count(); i++ )
            {
                if (Products[i] is T)
                {
                    productList.AppendLine($"Art.Number: {i + 1} " + Products[i].ProductInfo() + "\n");
                }
            }
            return productList.ToString();
        }


    }

}
