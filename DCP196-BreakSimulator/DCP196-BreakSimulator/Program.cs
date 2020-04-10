using System;

namespace DCP196_BreakSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] token = Console.ReadLine().Split(' ');

                double u = double.Parse(token[0]);
                double time = double.Parse(token[1]);

                
                Console.WriteLine("{0:0.00}", -1 * (u / time));
            }

        }
    }
}
