using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    // Subject interface
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

    // Observer interface
    public interface IObserver
    {
        void Update(string message);
    }

    // Concrete subject implementation
    public class ConcreteSubject : ISubject
    {
        private readonly List<IObserver> _observers = new();
        private string _state;

        public void RegisterObserver(IObserver observer) => _observers.Add(observer);
        public void RemoveObserver(IObserver observer) => _observers.Remove(observer);

        public void SetState(string newState)
        {
            _state = newState;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_state);
            }
        }
    }

    // Concrete observer implementation
    public class ConcreteObserver : IObserver
    {
        private readonly string _name;
        public ConcreteObserver(string name) => _name = name;
        public void Update(string message)
        {
            Console.WriteLine($"Observer '{_name}' received: {message}");
        }
    }

    // Demo class exposing a static Run method
    public static class ObserverPattern
    {
        public static void Run()
        {
            var subject = new ConcreteSubject();
            var observerA = new ConcreteObserver("A");
            var observerB = new ConcreteObserver("B");
            subject.RegisterObserver(observerA);
            subject.RegisterObserver(observerB);

            subject.SetState("State #1");
            subject.RemoveObserver(observerA);
            subject.SetState("State #2");
        }
    }
}
