using System;

namespace DesignPatterns.Singleton
{
    class SingletonDemo
    {
    public static void Run()
        {
            // Access the singleton instance and call its method
            Singleton.Instance.DoWork();
        }
    }
}
