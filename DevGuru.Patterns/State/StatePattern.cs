using DevGuru.Core;
using DevGuru.Patterns.State.Levels;

namespace DevGuru.Patterns.State
{
    public class StatePattern : PatternBase
    {
        public override string Name => "State";
        protected override string DescriptionFormatted => "\t[Allows an object to alter its behavior when its internal state changes,]\n\t[encapsulating the state-specific behavior in separate classes and delegating]\n\t[the state-specific logic to these classes.]\n";
        protected override string IdeaFormatted => "\t[]\n";

        protected override void RunCore()
        {
            var context = new Curriculum(new BegginerLevel(), "Math");
            context.PrintPlanInfo();
            context.PrintExamsInfo();

            if (context.Exam())
            {
                context.TransitionTo(new IntermediateLevel());
                context.PrintPlanInfo();
                context.PrintExamsInfo();

                if (context.Exam())
                {
                    context.TransitionTo(new AdvancedLevel());
                    context.PrintPlanInfo();
                    context.PrintExamsInfo();
                }
            }
        }
    }
}
