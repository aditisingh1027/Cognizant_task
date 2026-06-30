using System;

namespace DesignPatterns.Singleton
{
    /// <summary>
    /// Thread‑safe lazy singleton implementation.
    /// </summary>
    public sealed class Singleton
    {
        // Private static readonly instance created lazily.
        private static readonly Lazy<Singleton> _instance =
            new Lazy<Singleton>(() => new Singleton());

        // Private constructor prevents external instantiation.
        private Singleton()
        {
            // Initialize resources here.
        }

        /// <summary>
        /// Global access point.
        /// </summary>
        public static Singleton Instance => _instance.Value;

        public void DoWork()
        {
            Console.WriteLine("Singleton doing work at " + DateTime.Now);
        }
    }
}
