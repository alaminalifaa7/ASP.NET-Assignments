using System;
using System.Linq;

namespace _43_A_Football
{
    class Program
    {
        static void Main(string[] args)
        {
            int team1 = 0, team2 = 0;
            int a = int.Parse(Console.ReadLine());
            string[] array = new string[a];

            for (int i = 0; i < a; i++)
            {
                array[0] = Console.ReadLine();
            }

            var distinct = array.Distinct().ToArray();

            int distinctCount = distinct.Count();

            Console.WriteLine(distinct.Length);
            Console.WriteLine(distinctCount);

            //if (distinctCount > 1)
            //{
            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        if (distinct[0] == array[j])
            //        {
            //            team1 += 1;
            //        }
            //    }
            //}
            
            //Console.WriteLine(team1);

        }
    }
}
