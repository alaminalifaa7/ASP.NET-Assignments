using System;
using System.Collections.Generic;
using System.Linq;

namespace DCP_38_Mysterious_Pond
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            Dictionary<String, int> dict = new Dictionary<String, int>();

            for(int i = 0; i< n; i++)
            {

                string[] token = Console.ReadLine().Split(' ');

                string key = token[0];
                int val = int.Parse(token[1]);

                dict.Add(key, val);
                
            }
            //for (int i = 0; i < dict.Count; i++)
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}",dict.Keys.ElementAt(i),dict[dict.Keys.ElementAt(i)]);
            //}

            //foreach(KeyValuePair <string,int> item in dict)
            //{

            //    Console.WriteLine(" "+item.Key + " " + item.Value);
            //}

            int MaxValue = (dict.Values.Max());
            int MinValue = (dict.Values.Min());
            foreach (KeyValuePair<string,int> item in dict)
            {
                if(item.Value == MaxValue)
                    Console.Write(item.Key+" ");
                if(item.Value ==MinValue)
                    Console.Write(item.Key+" ");

            }
         


        }
    }
}
