using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int C = 0;
            int L = 0;
            int i = 0;
            string input = Console.ReadLine();
            string filename = "test" + input + ".txt";
            if (!File.Exists(filename))
            {
                Console.WriteLine("Файл не существует");
                return;
            }
            StreamReader reader = new StreamReader(filename);
            if (reader.EndOfStream)
            {
                Console.WriteLine("Файл пуст");
                return;
            }
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                Console.Write(line[0]);
                Console.Write(line[1]);
                Console.Write(line[2]);
                Console.Write(line[3]);
                Console.WriteLine();
            }

            Console.Write(i);
            reader.Close();

        }
    }
}

