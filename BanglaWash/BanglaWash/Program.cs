using System;
using System.Collections.Generic;
using System.Text;

namespace BanglaWash
{
    class Program
    {
        static void Main(String[] args) {


            int testCase;
            int a, b, c, d;
            int e, f, g, h;
            // double result;
            testCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
               // var line = Console.ReadLine();
                string [] tokens = Console.ReadLine().Split(' ');

               // int[] numbers = Array.ConvertAll(tokens, int.Parse);

                a = Convert.ToInt32(tokens[0]);
                b = Convert.ToInt32(tokens[1]);
                c = Convert.ToInt32(tokens[2]);
                d = Convert.ToInt32(tokens[3]);

                // Console.WriteLine("");
                string[] tokens2 = Console.ReadLine().Split(' ');

                // int[] numbers = Array.ConvertAll(tokens, int.Parse);

                e = Convert.ToInt32(tokens2[0]);
                f = Convert.ToInt32(tokens2[1]);
                g = Convert.ToInt32(tokens2[2]);
                h = Convert.ToInt32(tokens2[3]);

                int bd1 = a + b;
                int pak1 = c + d;

                int bd2 = e + f;
                int pak2 = g + h;

                if (bd1 > pak1 && bd2 > pak2)
                {
                    Console.WriteLine("Banglawash");
                }
                else
                {
                    Console.WriteLine("Miss");
                }

            }
        }
        
    }
}
