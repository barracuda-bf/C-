using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            double x;
            x = double.Parse(a);
            double s = x * 1.8+32;
            Console.WriteLine("{0:F4}", s);
        }
    }
}
