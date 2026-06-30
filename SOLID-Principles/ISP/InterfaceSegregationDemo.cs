using System;

namespace DesignPatterns.SOLIDPrinciples.ISP
{
    // Small, client‑specific interfaces
    public interface IBilling
    {
        void GenerateBill();
    }

    public interface IReporting
    {
        void GenerateReport();
    }

    // Class that needs only billing functionality
    public class BillingService : IBilling
    {
        public void GenerateBill()
        {
            Console.WriteLine("BillingService: Bill generated.");
        }
    }

    // Demo class exposing a static Run method
    public static class InterfaceSegregationDemo
    {
        public static void Run()
        {
            // Consumer that only cares about billing
            IBilling billing = new BillingService();
            billing.GenerateBill();
        }
    }
}
