using DevGuru.Core;

namespace DevGuru.Patterns.Facade
{
    public class FacadePattern : BasePattern
    {
        public override string Name => "Facade";
        protected override string DescriptionFormatted => "\t[Provides a simplified interface to a set of interfaces in a subsystem, making it easier]\n\t[to use and reducing dependencies between clients and the subsystem.]\n";
        protected override string IdeaFormatted => "\t[Facade is a pure fabrication. There are two abstract heavy subsystems and]\t\n[a Facade class provides a communication point for two of them.]\n";

        protected override void RunCore()
        {
            Client.Operation(new Facade(new SubSystemPrimary(), new SubSystemSecondary()));
        }
    }
}
