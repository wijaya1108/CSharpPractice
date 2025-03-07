using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Interfaces
{
    public interface IPayment
    {
        void ProcessPayment(decimal amount);
    }

    public class PayPal : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Paid {amount} via paypal");
        }
    }

    public class CreditCard : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Paid {amount} via credit card");
        }
    }

    public class PaymentProcessor
    {
        private readonly IPayment _payment;

        public PaymentProcessor(IPayment payment)
        {
            _payment = payment;
        }

        public void MakePayment(decimal amount)
        {
            _payment.ProcessPayment(amount);
        }
    }
}
