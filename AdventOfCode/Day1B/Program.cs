using System;
using System.Collections.Generic;
using System.Linq;

namespace Day1B
{
    class Program
    {

        static int GetFuelRequirement(int module, int origin = 0)
        {
            Func<int, int> fuelRequired = x => (x / 3) - 2;
            return fuelRequired(module) <= 0 ? origin : GetFuelRequirement(fuelRequired(module), origin += fuelRequired(module));   
        }

        static void Main(string[] args)
        {
            int fuelRequirements = 0;
            Array.ConvertAll(System.IO.File.ReadAllLines("modules.txt"), x => int.Parse(x)).ToList().ForEach(x =>
            {
                fuelRequirements += GetFuelRequirement(x);
            });

            Console.WriteLine($"The amount of fuel required is {fuelRequirements}");
            Console.ReadKey();
        }
    }
}
