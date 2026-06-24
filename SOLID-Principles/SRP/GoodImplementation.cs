// Good SRP implementation – each class has a single responsibility.
// Order represents the data model.
public record Order(int Id, string CustomerName, decimal Amount);

// Separate repository responsible for persisting orders.
public class OrderRepository {
    public void Save(Order order) {
        // Simulated persistence logic.
        System.Console.WriteLine($"Order {order.Id} saved.");
    }
}

// Validation logic isolated from persistence.
public class OrderValidator {
    public bool IsValid(Order order) => order.Amount > 0 && !string.IsNullOrWhiteSpace(order.CustomerName);
}

// Presentation logic isolated from business rules.
public class OrderPrinter {
    public void Print(Order order) => System.Console.WriteLine($"Order {order.Id}: {order.CustomerName} – ${order.Amount}");
}

