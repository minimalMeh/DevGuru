using System;

namespace DevGuru.Patterns.Facade
{
    public class SubSystemSecondary
    {
        public static void OperationBeta()
        {
            Console.WriteLine("Subsystem2: Beta");
        }

        public static void OperationDelta()
        {
            Console.WriteLine("Subsystem2: Delta");
        }
    }
}
