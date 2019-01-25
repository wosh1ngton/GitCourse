using System;
using System.Collections.Generic;

namespace ProjetoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The world is a marvelous place");

            List<string> list = new List<string>();
            list.Add("oi");
            list.Add("tudo");
            list.Add("bem");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            string oi = "oi";

            int n = 250;
        }
    }
}
