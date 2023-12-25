using System;

namespace DevGuru.Patterns.Facade
{
    public class SubSystemPrimary
    {
        public static void OperationAlpha()
        {
            Console.WriteLine("Subsystem1: Alpha");
        }

        public static void OperationOmega()
        {
            Console.WriteLine("Subsystem1: Omega");
        }
    }
}
