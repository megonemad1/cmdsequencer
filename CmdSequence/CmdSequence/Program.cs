using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoCmd;

namespace CmdSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Command a = new Command("runthis");
            a.AddPeram("-a", "structured");
            a.AddPeram("-a", "structured2");
            a.AddPeram("-d", "dg");
            Console.WriteLine(a.GetCommand());
            Console.ReadLine();
        }
    }
}
