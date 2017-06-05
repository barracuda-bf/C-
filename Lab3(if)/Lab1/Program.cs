using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            Double a, b;
            a = Double.Parse(t1);
            b = Double.Parse(t2);
            if (a < b)
            {
                Console.WriteLine("Второе");
            }
            else { Console.WriteLine("Первое"); 
            }
        }
    }
}
