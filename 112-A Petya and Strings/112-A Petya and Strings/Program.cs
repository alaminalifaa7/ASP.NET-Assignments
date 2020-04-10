using System;

namespace _112_A_Petya_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine().ToLower();
            string s2 = Console.ReadLine().ToLower();

            Console.WriteLine(s1.CompareTo(s2));
        }
    }
}
