using System;

namespace _282_A_Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;

            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();
                if (s[1] == '+')
                {
                    ans += 1;
                }
                else if (s[1] == '-')
                {
                    ans -= 1;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
