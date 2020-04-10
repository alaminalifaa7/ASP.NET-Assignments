using System;

namespace _1220_A_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 0,zero = 0;
            int t = int.Parse(Console.ReadLine());

            string w = Console.ReadLine();
            for (int i = 0; i < w.Length; i++)
            {
                if(w[i] == 'z')
                {
                    zero++;
                }
                else if(w[i] == 'n')
                {
                    one++;
                }
            }
            while (one !=0) { Console.WriteLine("1"); one--; }
            while (zero != 0) { Console.WriteLine("0"); zero--; }

        }
    }
}
