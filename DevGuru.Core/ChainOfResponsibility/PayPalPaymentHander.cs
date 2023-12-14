using System;

namespace DevGuru.Core.ChainOfResponsibility
{
    public class PayPalPaymentHander : BasePaymentHandler
    {
        public PayPalPaymentHander(BasePaymentHandler next = null)
        {
            Next = next;
        }

        public override void Handle(User user)
        {
            if (user.PayPalPayment)
            {
                Console.WriteLine("Transfer money by PayPal.");
            }
            else if (Next != null)
            {
                Next.Handle(user);
            }
        }
    }
}
