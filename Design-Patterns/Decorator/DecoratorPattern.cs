using System;

namespace DesignPatterns.Decorator
{
    // Component interface
    public interface IComponent
    {
        void Operation();
    }

    // Concrete component
    public class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteComponent: Performing operation.");
        }
    }

    // Base decorator
    public abstract class ComponentDecorator : IComponent
    {
        protected readonly IComponent _component;
        protected ComponentDecorator(IComponent component)
        {
            _component = component;
        }
        public virtual void Operation()
        {
            _component.Operation();
        }
    }

    // Concrete decorator adds behavior
    public class LoggingDecorator : ComponentDecorator
    {
        public LoggingDecorator(IComponent component) : base(component) { }
        public override void Operation()
        {
            Console.WriteLine("LoggingDecorator: Before operation.");
            base.Operation();
            Console.WriteLine("LoggingDecorator: After operation.");
        }
    }

    // Demo class
    public static class DecoratorPattern
    {
        public static void Run()
        {
            IComponent component = new ConcreteComponent();
            IComponent decorated = new LoggingDecorator(component);
            decorated.Operation();
        }
    }
}
