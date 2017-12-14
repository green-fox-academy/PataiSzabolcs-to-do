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
            if (args[0] == "-a")
            {
                try
                {
                    FileHandler handler = new FileHandler();
                    handler.AddTask(args[1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
            }
            if (args[0] == "-r")
            {
                int input = int.Parse(args[1]);
                FileHandler handler = new FileHandler();
                handler.RemoveTask(input - 1);
            }
            if (args[0] == "-c")
            {
                int input = int.Parse(args[1]);
                FileHandler handler = new FileHandler();
                handler.CheckTask(input - 1);
            }
        }
    }
}
