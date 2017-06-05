using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            int a;
            a = int.Parse(t);
            int s ;
            if (a <= 0) {
                Console.WriteLine("Значение а должно быть положительным");
                return;
            }
            s = 6 * a *a;
            Console.WriteLine("{0:F4}", s);
            }
    }
}
