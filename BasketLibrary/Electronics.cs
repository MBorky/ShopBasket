using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    public class Electronics : Product
    {
        public string Category {  get; private set; }
        public string Color { get; private set; }
        public Electronics(string name, decimal price, string category, string color) : base(name, price)
        {
            Category = category;
            Color = color;
        }
        public override string ProductInfo() 
        {
            return $"Product: {Name}, Category: {Category}, Color: {Color}\nPrice: {Price}";
        }

        public override Product Clone()
        {
            return new Electronics(Name, Price, Category, Color);
        }
    }
}
