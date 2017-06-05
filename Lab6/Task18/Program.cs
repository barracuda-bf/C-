using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x,sum=0,i=0;
            do {
             x = int.Parse(Console.ReadLine());
             sum +=x; // sum = sum+x;
             i = i + 1;
             } while (sum<=1000);
             Console.WriteLine (i);
            }
        }

    }


