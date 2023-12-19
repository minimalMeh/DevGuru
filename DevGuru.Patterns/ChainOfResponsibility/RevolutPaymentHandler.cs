using System;

namespace DevGuru.Patterns.ChainOfResponsibility
{
    public class RevolutPaymentHandler : BasePaymentHandler
    {
        public RevolutPaymentHandler(BasePaymentHandler next = null)
        {
            Next = next;
        }

        public override void Handle(UserPaymentInfo user)
        {
            if (user.RevolutPayment)
            {
                Console.WriteLine("Money were sent via the Revolut.");
            }
            else
            {
                Next?.Handle(user);
            }
        }
    }
}
