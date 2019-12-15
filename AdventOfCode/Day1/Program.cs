using System;
using System.Collections.Generic;
using System.Linq;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The amount of fuel required is {Array.ConvertAll(System.IO.File.ReadAllLines("modules.txt"), x => int.Parse(x)).ToList().Sum(x => (x / 3) - 2)}");
            Console.ReadKey();
        }
    }
}
