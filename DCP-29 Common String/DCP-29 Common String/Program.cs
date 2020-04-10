using System;

namespace DCP_29_Common_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= t; i++)
            {
                string[] token = Console.ReadLine().ToLower().Split(' ');

                string s1 = token[0];
                string s2 = token[1];

                // +1 bcz that is filled with 0 initially
                // and in the first comparison we are we are accessing that diagonal 0,0
                int[,] dp = new int[s1.Length+1,s2.Length+1];
                for (int m = 1; m <= s1.Length; m++)
                {
                    for (int n = 1; n <= s2.Length; n++)
                    {

                        if (s1[m-1] == s2[n-1])
                        {
                            dp[m, n] = dp[m - 1, n - 1] + 1;
                          //  Console.WriteLine("add hoilo"+m+","+n);
                        }
                        else
                        {
                            dp[m, n] = 0;
                        }
                            
                    }
                }
                int result = -1;
                for (int k = 0; k <= s1.Length; k++)
                {
                    for (int j = 0; j <= s2.Length; j++)
                    {
                        if (result < dp[k,j])
                        {
                            result = dp[k,j];
                        }
                    }
                }

                Console.WriteLine("Case {0}: "+result,i);
            }


        }
    }
}
