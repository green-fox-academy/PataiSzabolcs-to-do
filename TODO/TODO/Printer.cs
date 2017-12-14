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
            Console.WriteLine
                (
                    "\r\n" +
                    "Command Line Todo application\n" +
                    "=============================" +
                    "\r\n" +
                    "Command line arguments:\n" +
                    " -l\tLists all the tasks\n" +
                    " -a\tAdds a new task\n" +
                    " -r\tRemoves an task\n" +
                    " -c\tCompletes an task"
                );
        }
        public void PrintList()
        {
            string[] list = File.ReadAllLines(Filename);
            if (list.Length == 0)
            {
                Console.WriteLine($"No todos for today! :)");
            }
            else
            {
                foreach (string item in list)
                {
                    Console.WriteLine($"{Array.IndexOf(list, item) + 1} - {item}");
                }
            }
        }
    }
}
