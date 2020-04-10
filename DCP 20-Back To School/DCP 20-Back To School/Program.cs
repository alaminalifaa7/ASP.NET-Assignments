using System;

namespace DCP_20_Back_To_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int cx, cy, px, py;
            double r;
            for (int i = 1; i <= t; i++)
            {
                string[] token = Console.ReadLine().Split(' ');

                cx = int.Parse(token[0]);
                cy = int.Parse(token[1]);
                r = double.Parse(token[2]);
                px = int.Parse(token[3]);
                py = int.Parse(token[4]);

                double dSquared = Math.Pow((px - cx), 2)+ Math.Pow((py - cy), 2);
                double rSquared = Math.Pow(r, 2);

                if (dSquared < rSquared)
                {
                    Console.WriteLine("Case {0}: Inside",i);
                    
                }
                else if (dSquared > rSquared)
                {
                    Console.WriteLine("Case {0}: Outside", i);
                    
                }
                else
                    Console.WriteLine("Case {0}: OnCircle", i);
            }



        }
    }
}
