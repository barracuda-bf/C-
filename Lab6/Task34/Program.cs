using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task34
{
    class Program
    {
        static void Main(string[] args)
        {
            Double W, H, i = 0, c = 0;
            W = Double.Parse(Console.ReadLine());
            H = Double.Parse(Console.ReadLine());
            if (W < 0) { Console.WriteLine("Значение W должно быть неотрицательно"); return; }
            if (H < 0) { Console.WriteLine("Значение H должно быть неотрицательно"); return; }
            Console.Write(" ");
            while (i < W)
            {
                Console.Write(i);
                i = i + 1;
                
            }
            Console.WriteLine();
            while (c < H)  {
                Console.Write (c);
                i = 0;
                while (i < W)  { //вывести несколько пробелов   
                    i = i + 1;
                    Console.Write(" ");
                }
                Console.Write("|");//вывести |
                Console.WriteLine();
                c=c+1; }
            Console.Write(" ");
            i = 0;
            while (i < W)
            {
                Console.Write("-");
                i = i + 1;
            }
        }
    }
}
                