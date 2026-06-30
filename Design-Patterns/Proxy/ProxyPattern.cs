using System;

namespace DesignPatterns.Proxy
{
    // Subject interface
    public interface ISubject
    {
        void Request();
    }

    // Real subject performs the actual work
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling request.");
        }
    }

    // Proxy controls access to the real subject (protective proxy example)
    public class ProxySubject : ISubject
    {
        private readonly RealSubject _realSubject = new RealSubject();
        private bool _hasAccess;
        public ProxySubject(bool hasAccess)
        {
            _hasAccess = hasAccess;
        }
        public void Request()
        {
            if (_hasAccess)
            {
                Console.WriteLine("ProxySubject: Access granted.");
                _realSubject.Request();
            }
            else
            {
                Console.WriteLine("ProxySubject: Access denied.");
            }
        }
    }

    // Demo class with static Run method
    public static class ProxyPattern
    {
        public static void Run()
        {
            ISubject authorized = new ProxySubject(true);
            ISubject unauthorized = new ProxySubject(false);
            authorized.Request();
            unauthorized.Request();
        }
    }
}
