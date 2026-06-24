using System;

namespace DesignPatterns.Adapter
{
    // Target interface expected by client code
    public interface ITarget
    {
        void Request();
    }

    // Existing class with incompatible interface
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee: Specific request executed.");
        }
    }

    // Adapter makes Adaptee compatible with ITarget
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public void Request()
        {
            // Translate the request to the adaptee's method
            _adaptee.SpecificRequest();
        }
    }

    // Demo class with static Run method
    public static class AdapterPattern
    {
        public static void Run()
        {
            ITarget target = new Adapter(new Adaptee());
            target.Request();
        }
    }
}
