using System;

public class Program
{
    public void Main()
    {
        string[]cars = {"Porsche 911", "1932 Mercedes-Benz 190", "Nissan GTR", "Audi R8", "DeLorean", "Lamborghini Countach"};
		Console.WriteLine("These are my favourite " + (cars.Length) + " cars:");
        foreach(var car in cars)
        {
            Console.WriteLine("The " + car);
        }
    }
}