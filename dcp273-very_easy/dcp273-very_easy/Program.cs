using System;

namespace dcp273_very_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            

          int n = int.Parse(Console.ReadLine());
            for (int i = 0; i< n; i++)
            {

                string s = Console.ReadLine();
                bool t = true;
                for (int j = 0; j < s.Length; j++)
                {

                    if(s[j] == 'r')
                    {
                        t = false;
                        Console.WriteLine("Not vely easy");
                        break;

                    }
                }
                if (t == true) 
                {
                    Console.WriteLine("Vely easy");
                }
                
            }

        }
    }
}
