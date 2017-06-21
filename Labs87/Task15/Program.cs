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
            Console.WriteLine("Данные сверху(top):");
            String t = Console.ReadLine();
            string[] mas1 = t.Split(' ');
            Console.WriteLine("Данные слева(left):");
            String t1 = Console.ReadLine();
            string[] mas2 = t1.Split(' ');
            if (t == "") { Console.WriteLine("Данные сверху отсутствуют"); return; }
            if (t1 == "") { Console.WriteLine("Данные слева отсутствуют"); return; }
            int i = 0, c = 0;

            Console.Write("  ");
            while (i < mas1.Length)
            {
                Console.Write(mas1[i] + " ");
                i++;
            }
            Console.WriteLine();
            while (c < mas2.Length)
            {
                Console.Write(mas2[c] + " ");
                c++;
                i = 0;
                while (i < mas1.Length)
                { //вывести несколько пробелов   
                    i++;
                    Console.Write("  ");

                }
                Console.Write("|");//вывести |
                Console.WriteLine();
            }
            Console.Write(" ");
            i = 0;
            while (i < mas1.Length)
            {
                Console.Write("--");
                i++;

            }
        }
    }
}