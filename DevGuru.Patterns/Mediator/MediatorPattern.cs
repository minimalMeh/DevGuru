using DevGuru.Core;
using DevGuru.Patterns.Mediator;
using System.Threading;

namespace DevGuru.Patterns
{
    public class MediatorPattern : PatternBase
    {
        public override string Name => "Mediator";
        protected override string DescriptionFormatted => "\t[Defines an object that centralizes communication between a set of objects,]\n\t[promoting loose coupling and reducing direct connections between them.]\n";
        protected override string IdeaFormatted => "\t[The Manager can communicate with a lot of his enterprise colleagues.]\n\t[The Employee and the Customer are not communicating directly, only through a manager.]\n";

        protected override void RunCore()
        {
            var manager = new ManagerMediator();
            var executor = new Employee(manager);
            var customer = new Customer(manager);

            manager.Customer = customer;
            manager.Employee = executor;

            customer.Send("I need a new release.");
            Thread.Sleep(1000);
            executor.Send("Here is a new release.");
        }
    }
}
