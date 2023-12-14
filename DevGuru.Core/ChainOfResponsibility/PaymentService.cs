namespace DevGuru.Core.ChainOfResponsibility
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

        public void ProceedPayment(User user)
        {
            handler.Handle(user);
        }
    }
}
