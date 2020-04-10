using System;

namespace NumberSuccess
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] array1 = new string[5];
            String[] array2 = new string [5];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i]= Console.ReadLine();
                
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = Console.ReadLine();

            }
            for(int j =0; j<array1.Length; j++) {
                for (int i = 0; i < array2.Length; i++)
                {
                   
                    if (array1[i][0] == array2[j][0] && array1[i][1] == array2[j][1] &&array1[i][2] == array2[j][2])
                        //Console.WriteLine(array2[j][12]);
                        if (array2[j][12] == 's')
                        {
                            Console.WriteLine("success");
                            Console.WriteLine(array1[i] + " : " + array2[j]);
                        }
                        if (array2[j][12] == 'f')
                        {
                            Console.WriteLine("failure");
                            Console.WriteLine(array1[i] + " : " + array2[j]);
                        }
                }
            }
            
        }
    }
}
