using System;
using System.Collections.Generic;

public class Astronomy
{
    public static void Main()
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();
        inventory["planets"] = 8;
        inventory["solar_systems"] = 500;
        inventory["milky_way"] = 1;

        Console.WriteLine(inventory["planets"]);
        Console.WriteLine(inventory["solar_systems"]);
        Console.WriteLine(inventory["milky_way"]);

    }
}
