using System;

namespace DCP_117_Not_EasyNotHard
{
    class Program
    {
        static void Main(string[] args)
        {
          
           int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t;i++) 
            {
                int n = int.Parse(Console.ReadLine());
                int r = ((n * (n + 1)) / 2);
                Console.WriteLine(r);
            }
        }
    }
}
