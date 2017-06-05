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
            String t1;
            t1 = Console.ReadLine();
            Double K,x;
            K = Double.Parse(t1);
            if (K < 0)
            {
                x = Math.Pow(K, 2);
            }  else {
                x = Math.Sqrt(K);           
            }
            Console.WriteLine(x);
        }
    }
}
