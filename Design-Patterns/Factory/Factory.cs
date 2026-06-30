using System;

namespace DesignPatterns.Factory
{
    // Product interface
    public interface IProduct
    {
        void DoWork();
    }

    // Concrete product A
    public class ConcreteProductA : IProduct
    {
        public void DoWork()
        {
            Console.WriteLine("ConcreteProductA is working.");
        }
    }

    // Concrete product B
    public class ConcreteProductB : IProduct
    {
        public void DoWork()
        {
            Console.WriteLine("ConcreteProductB is working.");
        }
    }

    // Factory class
    public static class ProductFactory
    {
        public static IProduct CreateProduct(string type)
        {
            return type switch
            {
                "A" => new ConcreteProductA(),
                "B" => new ConcreteProductB(),
                _ => throw new ArgumentException($"Unknown product type: {type}")
            };
        }
    }
}
