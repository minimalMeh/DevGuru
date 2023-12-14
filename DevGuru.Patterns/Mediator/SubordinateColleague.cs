using System;

namespace DevGuru.Patterns.Mediator
{
    public class SubordinateColleague : Colleague
    {
        public SubordinateColleague(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine("Message to Subordinate employee: " + message);
        }
    }
}
