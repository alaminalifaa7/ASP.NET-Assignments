using System;

namespace DCP_166_POS_System
{
    class Program
    {
        static void Main(string[] args)
        {
            float p;
            int q;
            
            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                float bill = 0;
                int cash;
                int n = int.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    string[] token = Console.ReadLine().Split(' ');
                    
                    p = float.Parse(token[0]);
                    q = int.Parse(token[1]);
                    bill = bill + (p * q);
                }
                cash = int.Parse(Console.ReadLine());

                Console.WriteLine("Case {0}: "+ Math.Floor(cash-bill), i);

            }

        }
    }
}
