using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApplication(args);
        }
        // remove static?
        public static void RunApplication(string[] args)
        {
            if (args.Length == 0)
            {
                Printer printer = new Printer();
                printer.PrintUsage();
            }
            if (args[0] == "-l")
            {
                Printer printer = new Printer();
                printer.PrintList();
            }
        }
    }
}
