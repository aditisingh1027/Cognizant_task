using System;

namespace DesignPatterns.SOLIDPrinciples.DIP
{
    // Abstraction – high‑level module depends on this interface
    public interface ICalculator
    {
        int Add(int a, int b);
    }

    // Low‑level concrete implementation
    public class SimpleCalculator : ICalculator
    {
        public int Add(int a, int b) => a + b;
    }

    // High‑level class depends on the abstraction, not the concrete type
    public class MathClient
    {
        private readonly ICalculator _calculator;
        public MathClient(ICalculator calculator)
        {
            _calculator = calculator;
        }
        public void PerformAddition()
        {
            int result = _calculator.Add(3, 4);
            Console.WriteLine($"MathClient: 3 + 4 = {result}");
        }
    }

    // Demo exposing only a static Run method
    public static class DependencyInversionDemo
    {
        public static void Run()
        {
            // Dependency injection of the low‑level implementation
            ICalculator calculator = new SimpleCalculator();
            var client = new MathClient(calculator);
            client.PerformAddition();
        }
    }
}
