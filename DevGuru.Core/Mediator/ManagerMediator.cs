namespace DevGuru.Core.Mediator
{
    public class ManagerMediator : Mediator
    {
        public CustomerColleague Customer { get; set; }
        public SubordinateColleague Executor { get; set; }

        public override void Send(string msg, Colleague colleague)
        {
            if (colleague == Customer)
            {
                Executor.Notify(msg);
            }
            else if (colleague == Executor)
            {
                Customer.Notify(msg);
            }
        }
    }
}
