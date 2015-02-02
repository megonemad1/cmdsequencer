using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCmd
{
    public class Command
    {
        string _command;
        HashSet<argument> Param;
        public Command(string Command)
        {
            this._command = Command;
            Param = new HashSet<argument>();
        }
        public Command AddPeram(string PeramiterType, string arg)
        {
            Param.Add(new argument { Arg = arg, ArgType = PeramiterType });
            return this;
        }
        public string GetCommand()
        {
            return _command + " " + String.Join(" ", Param);
        }
    }
    struct argument
    {
        public string ArgType;
        public string Arg;
        public override string ToString()
        {
            return String.Format("{0} {1}", ArgType, Arg);
        }
    }
}
