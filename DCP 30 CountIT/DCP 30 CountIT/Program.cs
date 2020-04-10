using System;
using System.Linq;

namespace DCP_30_CountIT
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();

                string uniq = new string(s.Distinct().ToArray());
                char[] ch = uniq.ToCharArray();
                Array.Sort(ch);
                string uniqSort = String.Join("", ch);
                //Console.WriteLine(uniqSort);
                //Console.WriteLine(uniq[0]);
                //Console.WriteLine(uniq);

                int[] count = new int[uniq.Length];
                //   Console.WriteLine(count.Length);

                for (int j = 0; j < uniq.Length; j++)
                {
                    for (int k = 0; k < s.Length; k++)
                    {


                        if (uniq[j] == s[k])
                        {
                            count[j] += 1;
                        }

                    }
                }

                Console.WriteLine("Case {0}:", i + 1);
                for (int m = 0; m < uniq.Length; m++)
                {

                    Console.WriteLine(uniqSort[m] + " " + count[m]);
                }
            }
        }
    }
}
