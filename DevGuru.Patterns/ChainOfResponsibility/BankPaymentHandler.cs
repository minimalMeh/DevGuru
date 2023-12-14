using System;

namespace DevGuru.Patterns.ChainOfResponsibility
{
    public class BankPaymentHandler : BasePaymentHandler
    {
        public BankPaymentHandler(BasePaymentHandler next = null)
        {
            Next = next;
        }

        public override void Handle(User user)
        {
            if (user.BankPayment)
            {
                Console.WriteLine("Transfer money by Bank.");
            }
            else if (Next != null)
            {
                Next.Handle(user);
            }
        }
    }
}
