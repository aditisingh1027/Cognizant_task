using System;

namespace DesignPatterns.Factory
{
    // Demonstration class that uses the factory defined in Factory.cs
    public static class FactoryDemo
    {
        public static void Run()
        {
            // Create a product using the factory
            var product = ProductFactory.CreateProduct("A");
            product.DoWork();
        }
    }
}
