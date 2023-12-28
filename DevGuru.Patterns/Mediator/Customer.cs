using System;

namespace DevGuru.Patterns.Mediator
{
    public class Customer : Colleague
    {
        public Customer(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine("Dear Manager, I would like to share the following: " + message);
        }
    }
}
