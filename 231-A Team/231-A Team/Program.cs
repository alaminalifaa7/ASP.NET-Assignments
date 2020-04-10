using System;

namespace _231_A_Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans=0;
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t ; i++)
            {
                String[] token = Console.ReadLine().Split(' ');

                int n = (int.Parse(token[0]) + int.Parse(token[1]) + int.Parse(token[2]));

                if (n>=2)
                {
                    ans += 1;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
