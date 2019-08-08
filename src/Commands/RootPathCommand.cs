using System.Linq;

namespace Mono.Debugger.Client.Commands
{
    class RootPathCommand : Command
    {
        public override string[] Names => new string[]{ "rootpath"};
        public override string Summary => "set source file root path.";
        public override string Syntax => "rootpath <path/to/source/root>";
        public override void Process(string args)
        {
            args = args.Trim();
            if (args.Contains(' '))
            {
                Log.Error("Bad args.");
            }

            Debugger.SrcRootPath = args.Replace("\\", Debugger.PathSeparator);
	}
    }
}
