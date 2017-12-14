using System.IO;

namespace TODO
{
    class FileHandler
    {
        string Filename = "C:\\Users\\Szabi/Desktop\\TODO\\PataiSzabolcs-to-do\\TODO\\TODO\\List.txt";

        public void AddTask(string task)
        {
            StreamWriter writer = new StreamWriter(Filename);
            writer.WriteLine(task);
            writer.Close();
            //File.WriteAllText(Filename, task);
        }
    }
}
