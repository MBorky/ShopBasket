using System.Reflection;

namespace BasketLibrary
{

    public interface IClone<T>
    {
        T Clone();
    }
    public abstract class Product : IClone<Product>
    {
        public string Name { get;  private set; }
        public double Price { get; private set; }

        public Product (string name, double price)
        {
            Name = name;
            Price = price;
        }
        public abstract string ProductInfo();
        public abstract Product Clone();
        
    }
}