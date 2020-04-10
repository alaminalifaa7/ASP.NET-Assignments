using System;

namespace A_Divisibility_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            ulong a, b;
            for (int i = 0; i < t; i++)
            {
                string[] token = Console.ReadLine().Split(' ');

                a = ulong.Parse(token[0]);
                b = ulong.Parse(token[1]);

                /*
                 * solution 1: 
                 * the following brute logic gets TLE on  test 3
                 */

                //int count = 0;
                //while (a%b != 0)
                //{
                //    a = a + 1;
                //    count += 1;
                //}
                //Console.WriteLine(count);

                /*
                 * solution 2: 
                 * this however works, the following line only
                 */

                // Console.WriteLine((a + b - 1) / b * b - a);// magic magic magic 
                /*
                 * solution 3: 
                 * this works too
                 */
                if ( a % b == 0)
                {
                    Console.WriteLine(0);
                }
                else
                    Console.WriteLine(b - (a % b));

            }
        }
    }
}
