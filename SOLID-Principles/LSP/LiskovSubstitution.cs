// Liskov Substitution Principle (LSP) – derived classes can be substituted for their base class without breaking behavior.
public abstract class Bird {
    public abstract void Fly();
}

public class Sparrow : Bird {
    public override void Fly() => System.Console.WriteLine("Sparrow flies.");
}

// Penguin violates LSP if we put Fly in base; we fix by extracting ICanFly.
public interface ICanFly {
    void Fly();
}

public class Penguin : Bird, ICanFly {
    // Bird.Fly not appropriate for Penguin – we provide explicit interface implementation.
    void ICanFly.Fly() => System.Console.WriteLine("Penguin cannot fly.");
    public override void Fly() => ((ICanFly)this).Fly();
}

