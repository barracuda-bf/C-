using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task32
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1;
            t1 = Console.ReadLine();
            Double a, was;
            a = Double.Parse(t1);
            was = 12 * Math.Pow (a,2) + 7 * a - 16 ;
            Console.WriteLine("{0:F4}", was);
        }
    }
}
