using System;
using DesignPatterns.Factory;

namespace DesignPatterns.FactoryDemo
{
    class FactoryDemo
    {
    public static void Run()
        {
            IProduct productA = ProductFactory.CreateProduct("A");
            productA.DoWork();

            IProduct productB = ProductFactory.CreateProduct("B");
            productB.DoWork();
        }
    }
}
