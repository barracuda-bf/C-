using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            String msg; // переменная строки, для хранения иформации от пользователя
            msg = Console.ReadLine(); // получить информацию и записать в переменную msg 
            Console.WriteLine("Mы стремимся к " + msg); // выыодим значение переменной msg
        }
    }
}
