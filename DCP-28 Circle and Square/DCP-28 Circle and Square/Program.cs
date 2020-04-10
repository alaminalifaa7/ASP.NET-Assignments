using System;

namespace DCP_28_Circle_and_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            double r, side;
            for (int i = 0; i < t; i++)
            {
                string[] token = Console.ReadLine().Split(' ');

                r = double.Parse(token[0]);
                side = Math.Round((Double)double.Parse(token[1]),2);

                double diagonal = r * 2;

                //finding the largest possible side of the square
                //rounding the number to two decimal using math.round
                double PossibleLargestSide = Math.Round((Double)Math.Sqrt(Math.Pow(diagonal, 2)/2),2);
                //Console.WriteLine("daigonal {0}", diagonal);
                //Console.WriteLine("side {0}", side);
                //Console.WriteLine("largest side possible {0}",PossibleLargestSide);
                if (side == PossibleLargestSide)
                {
                    Console.WriteLine("Yes");
                }
                else
                    Console.WriteLine("No");
            }

        }
    }
}
