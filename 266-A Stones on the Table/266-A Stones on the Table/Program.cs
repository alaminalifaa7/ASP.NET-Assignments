using System;

namespace _266_A_Stones_on_the_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int t,count=0;
            t = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length - 1 ; i++)
            {
                if(s[i] == s[i + 1])
                {
                    count += 1;
                }
            }
          
            Console.WriteLine(count);

        }
    }
}
