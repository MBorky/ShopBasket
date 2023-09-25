using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    public class Clothing : Product
    {
        public string Size {  get; private set; }
        public string Color { get; private set; }
        public Clothing (string name, decimal price, string size, string color) : base(name, price)
        {
            Size = size;
            Color = color;  
        }
        public override string ProductInfo()
        {
            return $"Product: {Name}, Color: {Color}, Size: {Size}\nPrice: {Price}";
        }
        public override Product Clone()
        {
            return new Clothing(Name, Price, Size, Color);
        }
    }
}
