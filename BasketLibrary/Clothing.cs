using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    internal class Clothing : Product
    {
        public string Size {  get; private set; }
        public string Color { get; private set; }
        public Clothing (string name, double price, string size, string color) : base(name, price)
        {
            Size = size;
            Color = color;  
        }
        public override string ProductInfo()
        {
            return $"Produkt: {Name}, Kolor: {Color}, Rozmiar: {Size}\nCena: {Price}";
        }
        public override Product Clone()
        {
            return new Clothing(Name, Price, Size, Color);
        }
    }
}
