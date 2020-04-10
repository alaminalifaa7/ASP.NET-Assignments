using System;

namespace _596_A_Wilbur_and_Swimming_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            int x1, y1, x2, y2, x3, y3, x4, y4;
            
            if(points == 1)
            {
                string[] token = Console.ReadLine().Split(' ');

                x1 = int.Parse(token[0]);
                y1 = int.Parse(token[1]);

                Console.WriteLine(-1);
            }
            if (points == 2)
            {
                string[] token = Console.ReadLine().Split(' ');
                x1 = int.Parse(token[0]);
                y1 = int.Parse(token[1]);

                string[] token2 = Console.ReadLine().Split(' ');
                x2 = int.Parse(token2[0]);
                y2 = int.Parse(token2[1]);
                
                if((x2 > x1 || x1 > x2) && (y2 == y1 || x1 == x2))
                {
                    Console.WriteLine(-1);
                }
                else if ((x2 - x1 > 0 || x1 - x2 > 0) && (y2 - y1 > 0 || y1 - y2 > 0))
                {
                    Console.WriteLine(Math.Abs((x2 - x1) * (y2-y1)));
                }
                
            }
            if (points == 3)
            {
                string[] token = Console.ReadLine().Split(' ');
                x1 = int.Parse(token[0]);
                y1 = int.Parse(token[1]);

                string[] token2 = Console.ReadLine().Split(' ');
                x2 = int.Parse(token2[0]);
                y2 = int.Parse(token2[1]);

                string[] token3 = Console.ReadLine().Split(' ');
                x3 = int.Parse(token3[0]);
                y3 = int.Parse(token3[1]);

                double d1 = Math.Sqrt((Math.Abs((x1 - x2) * (x1 - x2))) + Math.Abs(((y1 - y2) * (y1 - y2))));
                double d2 = Math.Sqrt((Math.Abs((x3 - x2) * (x3 - x2))) + Math.Abs(((y3 - y2) * (y3 - y2))));
                Console.WriteLine(d1*d2);
            }
            if (points == 4)
            {
                string[] token = Console.ReadLine().Split(' ');
                x1 = int.Parse(token[0]);
                y1 = int.Parse(token[1]);

                string[] token2 = Console.ReadLine().Split(' ');
                x2 = int.Parse(token2[0]);
                y2 = int.Parse(token2[1]);

                string[] token3 = Console.ReadLine().Split(' ');
                x3 = int.Parse(token3[0]);
                y3 = int.Parse(token3[1]);

                string[] token4 = Console.ReadLine().Split(' ');
                x4 = int.Parse(token4[0]);
                y4 = int.Parse(token4[1]);

                double d1 = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
                double d2 = Math.Sqrt(((x3 - x2) * (x3 - x2)) + ((y3 - y2) * (y3 - y2)));
                Console.WriteLine(Math.Abs(d1 * d2));
            }

        }
    }
}
