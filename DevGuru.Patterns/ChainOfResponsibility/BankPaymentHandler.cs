using System;

namespace DevGuru.Patterns.ChainOfResponsibility
{
    public class BankPaymentHandler : BasePaymentHandler
    {
        public BankPaymentHandler(BasePaymentHandler next = null)
        {
            Next = next;
        }

        public override void Handle(UserPaymentInfo user)
        {
            if (user.BankPayment)
            {
                Console.WriteLine("Money were sent via the Bank.");
            }
            else
            {
                Next?.Handle(user);
            }
        }
    }
}
