// Proxy pattern demonstration
using System;

namespace DesignPatterns.Proxy
{
    public interface IImage
    {
        void Display();
    }

    public class RealImage : IImage
    {
        private readonly string _filename;
        public RealImage(string filename) => _filename = filename;
        public void Display() => Console.WriteLine($"Displaying {_filename}");
    }

    public class ImageProxy : IImage
    {
        private readonly string _filename;
        private RealImage _realImage;
        public ImageProxy(string filename) => _filename = filename;
        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_filename);
                Console.WriteLine("Loading image lazily...");
            }
            _realImage.Display();
        }
    }

    public static class ProxyDemo
    {
        public static void Run()
        {
            IImage image = new ImageProxy("sample.jpg");
            // Image not loaded yet
            image.Display(); // Loads then displays
        }
    }
}
