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
                Console.WriteLine("Command Line Todo application");
                Console.WriteLine("=============================");
                Console.WriteLine();
                Console.WriteLine("Command line arguments:");
                Console.WriteLine(" -l\tLists all the tasks");
                Console.WriteLine(" -a\tAdds a new task");
                Console.WriteLine(" -r\tRemoves an task");
                Console.WriteLine(" -c\tCompletes an task");
            }
        }
    }
}
