using DevGuru.Core;
using DevGuru.Patterns.Command;

namespace DevGuru.Patterns
{
    public class CommandPattern : PatternBase
    {
        public override string Name => "Command";
        protected override string DescriptionFormatted => "\t[Encapsulates a request as an object, allowing for parameterization of clients]\n\t[with different requests, queuing of requests, and support for undoable operations.]\n";
        protected override string IdeaFormatted => "\t[A TV is controlled by a remote.]\n\t[There are many commands in the remote control, one of them is a Power command.]\n";

        protected override void RunCore()
        {
            var tv = new TV();
            var tvCommand = new TVPowerCommand(tv);
            var remote = new TVRemote(tvCommand);

            remote.TurnOnTV();
            remote.TurnOffTV();
        }
    }
}
