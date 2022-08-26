﻿using System;

namespace DevGuru.Core.Mediator
{
    public class CustomerColleague : Colleague
    {
        public CustomerColleague(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine("Message to Customer: " + message);
        }
    }
}
