using System;

namespace DCP_35_Square_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0;i < 40; i++)
            //{
            //    if (i < 39)
            //        Console.Write(i * i + ",");
            //    else
            //        Console.WriteLine(i * i);

            //}

            int t = int.Parse(Console.ReadLine());

            for (int i =1;i<=t;i++)
            {
                int n = int.Parse(Console.ReadLine());

                double f = Math.Sqrt(n);
             //   bool isSquare = (f % 1 == 0) && (f-Math.Floor(f) == 0);
                bool isSquare = (f - Math.Floor(f) == 0);

                if (isSquare)
                {
                    Console.WriteLine("Case {0}: YES",i);
                }
                else
                    Console.WriteLine("Case {0}: NO",i);
            }

        }
    }
}
