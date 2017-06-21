using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 1, 2, 3, 4 };

            for (int i = 0; i < myArr.Length; i++)
                Console.Write(myArr[i]);

            Console.ReadLine();
        }
    }
}
