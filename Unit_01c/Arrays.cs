/* Lists are called "arrays" in C#
This program makes a list of cars.
It should print the length of the list and the first variable in the list */

using System;

public class Program
{
    public void Main()
    {
        string[]cars = {"Hellcat", "Mustang", "Camaro"};
        Console.WriteLine("This array -- also called a list -- has " + (cars.Length) + " variables.");
        Console.WriteLine("The first variable in this array is a " + (cars[0]) + ".") ;
    }
}