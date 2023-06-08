using System;
using System.Collections.Generic;

namespace CircleCIPackage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            List<int> list = new List<int>();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("done");
        }
    }
}
