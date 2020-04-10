using System;

namespace _263_A_Beautiful_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int [,] array = new int[5,5];
            int row = 0, col=0;
            int drow = 3, dcol = 3;

            for (int i = 0; i < 5 ; i++)
            {
                string[] token = Console.ReadLine().Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = Convert.ToInt32(token[j]);

                    if(array[i,j] == 1)
                    {
                        row = i+1;
                        col = j+1;
                    }
                }
            }

            //Console.WriteLine();
            //Console.WriteLine(row+" "+col);
            Console.WriteLine(Math.Abs(drow- row) + Math.Abs( dcol - col));

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("\n");
            //    for (int j = 0; j < 5; j++)
            //        Console.Write("{0} ", array[i, j]);
            //}



        }
    }
}
