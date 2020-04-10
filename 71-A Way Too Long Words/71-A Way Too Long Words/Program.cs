using System;

namespace _71_A_Way_Too_Long_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string w = Console.ReadLine();

                if (w.Length > 10 )
                {
                    Console.WriteLine(w[0]+""+(w.Length - 2)+""+w[(w.Length-1)]);
                }
                else
                {
                    Console.WriteLine(w);
                }
               
            }
        }
    }
}
