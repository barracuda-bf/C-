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
            Console.Write("B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("E: ");
            int E = int.Parse(Console.ReadLine());
            Console.WriteLine("Данные:");
            String t = Console.ReadLine();
            string[] arr = t.Split(' ');
            int r = arr.Length;
            if ((B >= r)||(B < 0))  { Console.WriteLine("Число B должно быть в интервале [0, размер массива)"); return; }
            if ((E >= r)||(E < 0)) { Console.WriteLine("Число E должно быть в интервале [0, размер массива)"); return; }
            if (B < E) {
                while (B <= E)
                {
                    Console.Write(arr[B] + " ");
                    B++;
                }
                } else {
                while (E<=B){
                    Console.Write(arr[E] + " ");
                    E++;}
                }
        }
    }
}

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