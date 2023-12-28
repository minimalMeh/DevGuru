namespace DevGuru.Patterns.Mediator
{
    public class ManagerMediator : Mediator
    {
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            Colleague rec = colleague == Customer ? Customer : Employee;
            rec?.Notify(message);
        }
    }
}
