using System;

namespace _791_A_Bear_and_Big_Brother
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            String [] token =  Console.ReadLine().Split(' ');

            int a = int.Parse(token[0]);
            int b = int.Parse(token[1]);


            do
            {
                a = a * 3;
                b = b * 2;

                count += 1;
            }
            while (a <= b);
            Console.WriteLine(count);

        }
    }
}
