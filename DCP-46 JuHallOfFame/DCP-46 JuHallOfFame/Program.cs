using System;

namespace DCP_46_JuHallOfFame
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0;i< t;i++)
            {

              string[] token = Console.ReadLine().Split(' ');

              ulong a = ulong.Parse(token[0]);
              ulong b = ulong.Parse(token[1]);


                if (a>b)
                {
                    Console.WriteLine(((a-b)/2) + b);
                }
                else if(a<b)
                    Console.WriteLine(((b-a)/2) + a);
                else
                    Console.WriteLine(a);
            }
        }
    }
}
