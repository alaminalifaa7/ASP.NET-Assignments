using System;
using System.Linq;
using System.Collections.Generic;

namespace _339_A_Helpful_Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string ans="";
            string [] token = s.Split('+');
            int[] a = new int[token.Length];
           // Console.WriteLine(token.Length);
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(token[i]);
            }

            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                if (i != a.Length-1)
                {
                    Console.Write("+");
                }
            }
           
        }
    }
}
