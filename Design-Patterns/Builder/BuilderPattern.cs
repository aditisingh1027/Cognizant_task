// Builder pattern demonstration
// Namespace: DesignPatterns.Builder
// This file provides a simple Builder implementation with a static Run method.

using System;

namespace DesignPatterns.Builder
{
    // Product class that will be built
    public class House
    {
        public int Floors { get; set; }
        public bool HasGarden { get; set; }
        public string? Material { get; set; }
        public override string ToString()
        {
            return $"House: Floors={Floors}, Garden={HasGarden}, Material={Material}";
        }
    }

    // Builder interface
    public interface IHouseBuilder
    {
        void BuildFloors();
        void BuildGarden();
        void BuildMaterial();
        House GetResult();
    }

    // Concrete builder
    public class ConcreteHouseBuilder : IHouseBuilder
    {
        private readonly House _house = new();
        public void BuildFloors() => _house.Floors = 2;
        public void BuildGarden() => _house.HasGarden = true;
        public void BuildMaterial() => _house.Material = "Brick";
        public House GetResult() => _house;
    }

    // Director orchestrates the building steps
    public class HouseDirector
    {
        private readonly IHouseBuilder _builder;
        public HouseDirector(IHouseBuilder builder) => _builder = builder;
        public void Construct()
        {
            _builder.BuildFloors();
            _builder.BuildGarden();
            _builder.BuildMaterial();
        }
        public House GetHouse() => _builder.GetResult();
    }

    // Demo class – static Run method (no Main)
    public static class BuilderDemo
    {
        public static void Run()
        {
            IHouseBuilder builder = new ConcreteHouseBuilder();
            var director = new HouseDirector(builder);
            director.Construct();
            House house = director.GetHouse();
            Console.WriteLine(house);
        }
    }
}
