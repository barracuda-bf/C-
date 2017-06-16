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
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (B > E) {
                for (int i = B; i <= E; i++)
                    Console.Write(array[i] + " "); 
                
            } else { 
            for (int i = E; i <= B; i--)
                    Console.Write(array[i] + " ");
            }
            //Console.ReadKey();
 
        }
    }
}
