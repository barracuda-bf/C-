using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2, t3, t4;
            t1 = Console.ReadLine();
            Double x, was;
            x = Double.Parse(t1);
            if (x < 1) {
                Console.WriteLine("Значение X должно быть не меньше 1");
            }
            was = Math.Sqrt(x + 1) + Math.Sqrt(x - 1) / 2 * Math.Sqrt(x);
            Console.WriteLine ("{0:F4}", was);
        }
    }
}
