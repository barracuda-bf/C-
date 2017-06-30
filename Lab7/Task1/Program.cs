using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            String t = "abcdefwxyz";
            String input = Console.ReadLine();
            if (t.Contains(input))
            {
                Console.WriteLine("Содержится");
            }
            else
            {
                Console.WriteLine("Не содержится");
            }
            if ("abcdefwxyz".Contains(input))
            {
                Console.WriteLine("Содержится");
            }
            else
            {
                Console.WriteLine("Не содержится");
            }
        }
    }
}
