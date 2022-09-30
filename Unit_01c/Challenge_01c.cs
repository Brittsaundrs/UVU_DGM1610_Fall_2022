using System;

public class Program
{
    public void Main()
    {
        string[]plants = {"Golden Pothos", "Aglaonema", "Aglaonema", "Sansevieria", "Unknown"};
		Console.WriteLine("These are the " + (plants.Length) + " plants I own:");
        plants[2] = "Another Aglaonema";
		foreach(var plant in plants)
        {
            Console.WriteLine(plant);
        }
    }
}