using System;

namespace DCP_26_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {

                string s = Console.ReadLine();
                for(int j = s.Length-1; j >=0; j--)
                {
                    Console.Write(s[j]);
                   

                }
                Console.WriteLine("");


            }


        }
    }
}
