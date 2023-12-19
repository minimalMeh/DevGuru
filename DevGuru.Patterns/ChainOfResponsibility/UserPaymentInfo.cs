using System;

namespace DevGuru.Patterns.ChainOfResponsibility
{
    // Receiver
    public class UserPaymentInfo
    {
        public bool BankPayment { get; private set; }
        public bool RevolutPayment { get; private set; }
        public bool PayPalPayment { get; private set; }

        public UserPaymentInfo(bool bank, bool revolut, bool paypal)
        {
            Console.WriteLine($"Set up {nameof(UserPaymentInfo)}: Bank {bank}, Revolut {revolut}, PayPal {paypal}");
            BankPayment = bank;
            RevolutPayment = revolut;
            PayPalPayment = paypal;
        }
    }
}
