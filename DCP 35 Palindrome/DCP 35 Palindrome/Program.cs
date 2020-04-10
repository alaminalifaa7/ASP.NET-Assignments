using System;

namespace DCP_35_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < t; i++)
            {
                bool b = true;
                string s = Console.ReadLine();
                int loopRun = s.Length / 2;
                //Console.WriteLine(loopRun);
                for (int j = 0; j < loopRun; j++)
                {
                    if (s[j] != s[s.Length - j - 1])
                    {
                        //Console.WriteLine(s[j]);
                        b = false; break;
                    }


                }
                if (b)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

            }
        }
    }
}