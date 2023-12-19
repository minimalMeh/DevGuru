using System;

namespace DevGuru.Patterns.ChainOfResponsibility
{
    public class PayPalPaymentHander : BasePaymentHandler
    {
        public PayPalPaymentHander(BasePaymentHandler next = null)
        {
            Next = next;
        }

        public override void Handle(UserPaymentInfo user)
        {
            if (user.PayPalPayment)
            {
                Console.WriteLine("Money were sent via the PayPal.");
            }
            else
            {
                Next?.Handle(user);
            }
        }
    }
}
