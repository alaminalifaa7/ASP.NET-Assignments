using System;

namespace _281_A_Word_Capitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string s1 = s[0].ToString().ToUpper();
            s = s.Remove(0,1);
            Console.WriteLine(s1+s);

        }
    }
}
