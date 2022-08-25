using System;
using System.Collections.Generic;
using System.Text;

namespace DevGuru.Core.Facade
{
    public class Facade
    {
        protected Subsystem1 subsystem1;
        protected Subsystem2 subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this.subsystem1 = subsystem1;
            this.subsystem2 = subsystem2;
        }

        public void Operation()
        {
            Console.WriteLine("Facade initialization.\n");
            subsystem1.OperationAlpha();
            subsystem2.OperationBeta();
            subsystem2.OperationDelta();
            subsystem1.OperationOmega();
            Console.WriteLine("Facade finalization.\n");
        }
    }
}
