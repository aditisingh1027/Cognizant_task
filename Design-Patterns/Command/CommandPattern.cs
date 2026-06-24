using System;
using System.Collections.Generic;

namespace DesignPatterns.Command
{
    // Command interface
    public interface ICommand
    {
        void Execute();
    }

    // Concrete command that adds a value
    public class AddCommand : ICommand
    {
        private readonly Calculator _calculator;
        private readonly int _value;
        public AddCommand(Calculator calculator, int value)
        {
            _calculator = calculator;
            _value = value;
        }
        public void Execute() => _calculator.Add(_value);
    }

    // Concrete command that subtracts a value
    public class SubtractCommand : ICommand
    {
        private readonly Calculator _calculator;
        private readonly int _value;
        public SubtractCommand(Calculator calculator, int value)
        {
            _calculator = calculator;
            _value = value;
        }
        public void Execute() => _calculator.Subtract(_value);
    }

    // Simple receiver class
    public class Calculator
    {
        private int _total = 0;
        public void Add(int value)
        {
            _total += value;
            Console.WriteLine($"Added {value}, total = {_total}");
        }
        public void Subtract(int value)
        {
            _total -= value;
            Console.WriteLine($"Subtracted {value}, total = {_total}");
        }
    }

    // Invoker that holds and runs commands
    public class Invoker
    {
        private readonly List<ICommand> _commands = new();
        public void AddCommand(ICommand cmd) => _commands.Add(cmd);
        public void ExecuteAll()
        {
            foreach (var cmd in _commands)
                cmd.Execute();
        }
    }

    // Demo class exposing a static Run method
    public static class CommandPattern
    {
        public static void Run()
        {
            var calculator = new Calculator();
            var invoker = new Invoker();
            invoker.AddCommand(new AddCommand(calculator, 10));
            invoker.AddCommand(new SubtractCommand(calculator, 3));
            invoker.AddCommand(new AddCommand(calculator, 5));
            invoker.ExecuteAll();
        }
    }
}
