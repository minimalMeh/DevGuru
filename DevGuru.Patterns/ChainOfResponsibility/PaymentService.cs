namespace DevGuru.Patterns.ChainOfResponsibility
{
    public class PaymentService
    {
        private readonly BasePaymentHandler handler;

        public PaymentService()
        {
            var pp = new PayPalPaymentHander();
            var rev = new RevolutPaymentHandler(pp);
            var bank = new BankPaymentHandler(rev);

            handler = bank;
        }

        public void ProceedPayment(UserPaymentInfo user)
        {
            handler.Handle(user);
        }
    }
}
