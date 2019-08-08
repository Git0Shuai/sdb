namespace Mono.Debugger.Client.Commands
{
    class Disconnect: Command
    {
        public override string[] Names => new[] {"Disconnect"};
        public override string Summary => "Reset state then detach.";
        public override string Syntax => "Disconnect";
        public override void Process(string args)
        {
            Debugger.DisConnect();
        }
    }
}
