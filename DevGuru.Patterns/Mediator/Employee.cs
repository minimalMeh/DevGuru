using System;

namespace DevGuru.Patterns.Mediator
{
    public class Employee : Colleague
    {
        public Employee(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine("Hi Manager. " + message);
        }
    }
}
