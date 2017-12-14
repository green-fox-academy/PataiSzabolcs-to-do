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
            else if (args[0] != "-l" && args[0] != "-a" && args[0] != "-r" && args[0] != "-c")
            {
                Console.WriteLine("Unsupported argument");
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
                try
                {
                    int input;
                    bool result = int.TryParse(args[1], out input);
                    if(result)
                    {
                        FileHandler handler = new FileHandler();
                        handler.RemoveTask(input - 1);
                    }
                    else
                    {
                        Console.WriteLine("Unable to remove: index is not a number");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to remove: no index provided");
                }
            }

            if (args[0] == "-c")
            {
                try
                {
                    int input;
                    bool result = int.TryParse(args[1], out input);
                    if (result)
                    {
                        FileHandler handler = new FileHandler();
                        handler.CheckTask(input - 1);
                    }
                    else
                    {
                        Console.WriteLine("Unable to remove: index is not a number");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to remove: no index provided");
                }
            }
        }
    }
}
