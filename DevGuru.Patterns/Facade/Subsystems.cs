using System;

namespace DevGuru.Patterns.Facade
{
    public class Subsystem1
    {
        public void OperationAlpha()
        {
            Console.WriteLine("Subsystem1: Alpha\n");
        }

        public void OperationOmega()
        {
            Console.WriteLine("Subsystem1: Omega\n");
        }
    }

    public class Subsystem2
    {
        public void OperationBeta()
        {
            Console.WriteLine("Subsystem2: Beta\n");
        }

        public void OperationDelta()
        {
            Console.WriteLine("Subsystem2: Delta\n");
        }
    }
}
