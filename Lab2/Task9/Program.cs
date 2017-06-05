using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b;
            a = Console.ReadLine();
            int T;
            T = int.Parse(a);
            int T1 = T % 360; //остаток отделения
            Console.WriteLine(T1);
        }
    }
}
