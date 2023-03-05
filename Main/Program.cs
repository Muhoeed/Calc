using System;
using System.IO;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args[0];
            FileStream file = new FileStream(path, FileMode.Open);
            StreamReader reader = new StreamReader(file);
            string line = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(line);
            Console.WriteLine("Нажмите любую клавишу, а затем Enter");
            int key1 = Console.Read();

        }

    }
}
