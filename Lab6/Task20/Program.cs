using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            Double A,B, sum = 0,c=0;
            A = Double.Parse(Console.ReadLine());
            B = Double.Parse(Console.ReadLine());
            while (A <= B) { 
                sum = sum + Math.Pow(A, 2);
                A = A + 1;}
            Console.WriteLine(sum);   
        }
    }
}
               