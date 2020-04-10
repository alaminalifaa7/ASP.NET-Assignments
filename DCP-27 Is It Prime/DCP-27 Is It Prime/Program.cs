using System;

namespace DCP_27_Is_It_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < t; i++)
            {
                bool flag = true;
                int n = int.Parse(Console.ReadLine());

                if (n <= 1)
                {
                    flag = false;
                }
                else if(n >= 2)
                {
                    for(int k = 2; k < n; k++)
                    {
                        if(n % k == 0)
                        {
                            flag = false;
                        }
                    }
                   
                }
                if(flag)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");

            }


        }
    }
}
