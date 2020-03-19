using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }

            var lastPlanets = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(lastPlanets);
            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }

            var rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine("These are the rocky planets...");
            foreach (var planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }

            planetList.Remove("Pluto");
            Console.WriteLine("These are the real planets.  No Dwarves!");
            foreach(var planet in planetList)
            {
                Console.WriteLine(planet);
            }

            var voyager1 = new List<string>() { "Jupiter", "Saturn" };
            var voyager2 = new List<string>() { "Jupiter", "Saturn", "Uranus", "Neptune" };
            var newHorizons = new List<string>() { "Pluto" };
            var pioneer2 = new List<string>() { "Jupiter", "Saturn" };

            var probes = new Dictionary<string, List<string>> ();

            probes.Add("Voyager1", voyager1);
            probes.Add("Voyager2", voyager2);
            probes.Add("New Horizons", newHorizons);
            probes.Add("Pioneer2", pioneer2);

            Console.WriteLine("These are the probes...");
            foreach (var (key, values) in probes)
            {
                foreach (var value in values)
                {
                  
                // Console.WriteLine($"{key} {value}");
                    foreach (var planet in planetList)
                    {
                        if (value == planet)
                        {
                            Console.WriteLine($"{key} {value}");
                        }
                    }
                }
            }

        }
    }
}
