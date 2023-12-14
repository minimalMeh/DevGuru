namespace DevGuru.Patterns.ChainOfResponsibility
{
    public abstract class BasePaymentHandler
    {
        protected BasePaymentHandler Next { get; set; }
        public abstract void Handle(User user);
    }
}
