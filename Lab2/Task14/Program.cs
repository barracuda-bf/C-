using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            String a,b;
            a = Console.ReadLine();
             b = Console.ReadLine();
            double x,y;
            x = double.Parse(a);
            y = double.Parse(b);
            double s = x * Math.Sqrt(-7*y);
            Console.WriteLine("{0:F4}", s);
        }
    }
}
 