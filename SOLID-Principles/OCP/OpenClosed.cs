// Open‑Closed Principle (OCP) – classes are open for extension but closed for modification.
// Shape base class with virtual Area method.
public abstract class Shape {
    public abstract double Area();
}

// Rectangle extends Shape without modifying Shape.
public class Rectangle : Shape {
    public double Width { get; init; }
    public double Height { get; init; }
    public override double Area() => Width * Height;
}

// Circle extends Shape without modifying existing code.
public class Circle : Shape {
    public double Radius { get; init; }
    public override double Area() => System.Math.PI * Radius * Radius;
}

public class AreaCalculator {
    // Method accepts any Shape – new shapes can be added without changing this class.
    public double TotalArea(params Shape[] shapes) {
        double total = 0;
        foreach (var s in shapes) total += s.Area();
        return total;
    }
}

