using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TODO
{
    class Printer
    {
        string Filename = "C:\\Users\\Szabi/Desktop\\TODO\\PataiSzabolcs-to-do\\TODO\\TODO\\List.txt";
        public void PrintUsage()
        {
            Console.WriteLine();
            Console.WriteLine("Command Line Todo application");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine("Command line arguments:");
            Console.WriteLine(" -l\tLists all the tasks");
            Console.WriteLine(" -a\tAdds a new task");
            Console.WriteLine(" -r\tRemoves an task");
            Console.WriteLine(" -c\tCompletes an task");
        }
        public void PrintList()
        {
            string[] list = File.ReadAllLines(Filename);
            foreach (string item in list)
            {
                Console.WriteLine($"{Array.IndexOf(list, item) + 1} - {item}");
            }
        }
    }
}
