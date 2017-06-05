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
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            Double p, q;
            p = Double.Parse(t1);
            q = Double.Parse(t2);
            if (p < q)
            {
                Console.WriteLine("Максимальное "+q+", Минимальное "+ p);
            }
            else
            {
                Console.WriteLine("Максимальное " + p + ", Минимальное " + q);
            }
        }
    }
}
