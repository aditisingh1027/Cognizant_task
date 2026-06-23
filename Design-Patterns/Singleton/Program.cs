using System;

namespace DesignPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Access the singleton instance and call its method
            Singleton.Instance.DoWork();
        }
    }
}
