using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            String a,b;
            a = Console.ReadLine();
            b = Console.ReadLine();
            int T,L;
            T = int.Parse(a);
            L = int.Parse(b);
            int T1 = T*100/L; //остаток отделения
            double T2 = T * 100 % L;
            Console.WriteLine("{0} шт и {1} см",T1,T2);
        }

    }
}
