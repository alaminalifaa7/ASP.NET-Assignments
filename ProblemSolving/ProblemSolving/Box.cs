using System;

namespace ProblemSolving
{
    class Box
    {
        static void Main(string[] args)
        {
            int testCase;
            double a, b, c;
            double result;
            testCase = Convert.ToInt32(Console.ReadLine());

            for ( int i = 0; i<testCase;i++)
            {

                string[] token = Console.ReadLine().Split(' ');

                a = double.Parse(token[0]);
                b = double.Parse(token[1]);
                c = double.Parse(token[2]);


                result = Math.Sqrt(a * a + b * b + c * c);
                Console.WriteLine(String.Format("{0:0.00}", result));
            }



        }
    }
}
