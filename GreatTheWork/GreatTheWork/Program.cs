using System;
using System.Collections.Generic;
using System.Linq;

namespace GreatTheWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalHours;
            List<int> t = new List<int>();
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] token = line.Split(' ');

                for (int i = 0; i < int.Parse(token[1]); i++)
                {
                    t.Add(int.Parse(Console.ReadLine()));
                }
                totalHours = int.Parse(token[0]);

                int Time = t.Sum();
                if (totalHours <= Time)
                {
                    Console.WriteLine("Project will finish within 1 day.");
                }
                else if (totalHours > Time)
                {
                    if (totalHours % Time == 0)
                    {
                        Console.WriteLine("Project will finish within {0} days.", totalHours / Time);
                    }
                    else
                    {
                        Console.WriteLine("Project will finish within {0} days.", totalHours / Time + 1);
                    }
                }

                t.Clear();
            }

        }
    }
}
