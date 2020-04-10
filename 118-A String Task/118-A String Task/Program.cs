using System;

namespace _118_A_String_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string w = Console.ReadLine().ToLower();
            

            for (int i = 0; i < w.Length; i++)
            {
                
                if (w[i] == 'u' || w[i] == 'e' || w[i] == 'i' || w[i] == 'o' || w[i] == 'a' || w[i] == 'y')
                {
                    
                    w =  w.Replace(w[i].ToString(), "");
                    i = 0;
                }
            }

            for (int j = 0; j < w.Length; j++)
            {
                Console.Write("."+w[j]);
            }

        }
    }
}
