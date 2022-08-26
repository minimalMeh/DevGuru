using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.ChainOfResponsibility
{
    public class RevolutPaymentHandler : BasePaymentHandler
    {
        public RevolutPaymentHandler(BasePaymentHandler next = null)
        {
            Next = next;
        }

        public override void Handle(User user)
        {
            if (user.RevolutPayment)
            {
                Console.WriteLine("Transfer money by Revolut.");
            }
            else if (Next != null)
            {
                Next.Handle(user);
            }
        }
    }
}
