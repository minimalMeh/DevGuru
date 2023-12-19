namespace DevGuru.Patterns.ChainOfResponsibility
{
    public class ChainOfResponsibilityPattern : BasePattern
    {
        public override string Name => "Chain Of Responsibility";

        public override string IdeaFormatted => "\t[A user can have Bank, Revolut and PayPal payment systems.]\n\t[The payment method is selected by the priority: Bank -> Revolut -> PayPal.]\n";

        public override void RunCore()
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
