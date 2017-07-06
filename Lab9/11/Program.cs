using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            string s =" Привет       мир и   ";
            int c = 0;
            for (int i=0; i<s.Length; i++)
            {
                if ((i < (s.Length-1)))
                {
                    if ((s[i] == ' ') && (s[i + 1] != ' ')) c++;
                }             
            }
            Console.WriteLine("In the string is {0} word('s).", c);
            Console.ReadKey();
            }
        }
    }

