namespace DevGuru.Core.ChainOfResponsibility
{
    public abstract class BasePaymentHandler
    {
        protected BasePaymentHandler Next { get; set; }
        public abstract void Handle(User user);
    }
}
