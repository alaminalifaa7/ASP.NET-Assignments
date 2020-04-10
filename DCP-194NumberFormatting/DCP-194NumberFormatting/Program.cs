using System;

namespace DCP_194NumberFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for(int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();

                if(s[0] == '0')
                {

                    switch (s[2])
                    {
                        case '1': Console.WriteLine("88"+s+" Citycell");
                            break;
                        case '5':
                            Console.WriteLine("88" + s + " Teletalk");
                            break;
                        case '6':
                            Console.WriteLine("88" + s + " Airtel");
                            break;
                        case '7':
                            Console.WriteLine("88" + s + " Grameenphone");
                            break;
                        case '8':
                            Console.WriteLine("88" + s + " Robi");
                            break;
                        case '9':
                            Console.WriteLine("88" + s + " Banglalink");
                            break;
                    }

                }

                else if(s[0] == '8')
                {
                        switch (s[4])
                        {
                            case '1':
                                Console.WriteLine( s + " Citycell");
                                break;
                            case '5':
                                Console.WriteLine( s + " Teletalk");
                                break;
                            case '6':
                                Console.WriteLine( s + " Airtel");
                                break;
                            case '7':
                                Console.WriteLine(s + " Grameenphone");
                                break;
                            case '8':
                                Console.WriteLine(s + " Robi");
                                break;
                            case '9':
                                Console.WriteLine( s + " Banglalink");
                                break;
                        }

                }

            }
        }
    }
}
