using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            String a,h;
            a = Console.ReadLine();
            h = Console.ReadLine();
            double x,y;
            x = double.Parse(a);
            y = double.Parse(h);
            double s = x*y/ 2;
            Console.WriteLine("{0:F2}", s);
        }
    }
}
