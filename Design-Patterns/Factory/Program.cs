using System;
using DesignPatterns.Factory;

namespace DesignPatterns.FactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct productA = ProductFactory.CreateProduct("A");
            productA.DoWork();

            IProduct productB = ProductFactory.CreateProduct("B");
            productB.DoWork();
        }
    }
}
