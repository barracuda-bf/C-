using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();          
            String filename = "test" + input + ".txt"; 
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
            string line = reader.ReadLine();
            
            int i = 0;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                i = i + 1;
                            }
            Console.Write(" "+i);
            reader.Close();
        }
    }
}
