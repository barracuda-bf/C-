using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            String simvol = Console.ReadLine(); //сканер букв
            String input = Console.ReadLine(); // сканер для цифры
            String filename = "test" + input + ".txt";
            if (!File.Exists(filename)) { Console.WriteLine("Файл не существует"); return;}

            StreamReader reader = new StreamReader(filename);
            if (reader.EndOfStream) {Console.WriteLine("Файл пуст");return;}
            string line = reader.ReadLine();
            
            int i = 0;
            while (!reader.EndOfStream)
            {

                if (line.Contains(simvol))
                {
                    line = reader.ReadLine();
                    i = i + 1;
                }
                else
                {
                    line = reader.ReadLine();
                }
            }
            Console.Write(" " + i);
            reader.Close();
        }
    }
}
 