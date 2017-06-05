using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1;
            t1 = Console.ReadLine();
            Double A,x;
            A = Double.Parse(t1);
            if (A < 0)
            {
                x = A * -1;
                Console.WriteLine(x);
            } else { Console.WriteLine(A); }

        }
    }
}
