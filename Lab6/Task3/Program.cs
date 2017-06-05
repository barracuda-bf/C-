using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            String t1, t2;
            t1 = Console.ReadLine();
            t2 = Console.ReadLine();
            double A, B;
            A = Double.Parse(t1);
            B = Double.Parse(t2);
            if (A > B)
            {
                Console.WriteLine("Значение A должно быть не больше значения B"); return;
            }
            else
            {
                while (B > A)
                {
                    Console.WriteLine(A);
                    A = A + 1;
                }
            }
        }
    }
}
