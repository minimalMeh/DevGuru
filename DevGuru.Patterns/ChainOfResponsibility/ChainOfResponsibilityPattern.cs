using DevGuru.Core;

namespace DevGuru.Patterns.ChainOfResponsibility
{
    public class ChainOfResponsibilityPattern : BasePattern
    {
        public override string Name => "Chain Of Responsibility";
        protected override string DescriptionFormatted => "\t[Passes a request along a chain of handlers, each processing the request or passing it]\n\t[to the next handler in the chain, providing a way to decouple senders and receivers.]\n";
        protected override string IdeaFormatted => "\t[A user can have Bank, Revolut and PayPal payment systems.]\n\t[The payment method is selected by the priority: Bank -> Revolut -> PayPal.]\n";

        protected override void RunCore()
        {
            var paymentService = new PaymentService();

            var user1 = new UserPaymentInfo(false, true, true);
            paymentService.ProceedPayment(user1);

            var user2 = new UserPaymentInfo(true, true, true);
            paymentService.ProceedPayment(user2);

            var user3 = new UserPaymentInfo(false, false, true);
            paymentService.ProceedPayment(user3);
        }
    }
}
