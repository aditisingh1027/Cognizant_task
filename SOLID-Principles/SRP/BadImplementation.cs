using System;

namespace SRPBad
{
    // This class violates SRP by handling validation, persistence, and notification.
    public class OrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            // Validation
            if (order.Total < 0)
                throw new InvalidOperationException("Invalid total");

            // Persistence
            using var ctx = new AppDbContext();
            ctx.Orders.Add(order);
            ctx.SaveChanges();

            // Notification
            var email = new SmtpClient();
            email.Send(order.CustomerEmail, "Order Confirmation", "Your order is confirmed");
        }
    }

    // Dummy supporting classes to keep the sample self‑contained
    public class Order { public decimal Total; public string CustomerEmail; }
    public class AppDbContext : IDisposable { public DbSet<Order> Orders = new(); public void SaveChanges() {} public void Dispose() {} }
    public class DbSet<T> { public void Add(T entity) {} }
    public class SmtpClient { public void Send(string to, string subject, string body) {} }
}
