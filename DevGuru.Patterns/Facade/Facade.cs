using System;

namespace DevGuru.Patterns.Facade
{
    public class Facade
    {
        protected SubSystemPrimary subsystem1;
        protected SubSystemSecondary subsystem2;

        public Facade(SubSystemPrimary subsystem1, SubSystemSecondary subsystem2)
        {
            this.subsystem1 = subsystem1;
            this.subsystem2 = subsystem2;
        }

#pragma warning disable CA1822 // Mark members as static
        public void Operation()
#pragma warning restore CA1822 // Mark members as static
        {
            Console.WriteLine("Facade initialization.");
            SubSystemPrimary.OperationAlpha();
            SubSystemSecondary.OperationBeta();
            SubSystemSecondary.OperationDelta();
            SubSystemPrimary.OperationOmega();
            Console.WriteLine("Facade finalization.\n");
        }
    }
}
