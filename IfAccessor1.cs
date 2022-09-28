using System;
					
public class Program
{
	public Operations myOperator;
	public void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("Hello");
		myOperator.DoMath(10, 4);
		myOperator.DoMath(20, 7);
		myOperator.DoMath(30, 15);
		myOperator.Compare(4, 3);
		myOperator.Compare(3, 4);
		myOperator.CheckPassword("ouke23");
		myOperator.CheckPassword("hskf3847");
	}
}

public class Operations
{
	public void DoMath(int value, int value2)
	{
		var number = value + value2;
		Console.WriteLine(number);
	}
	
	public void Compare (int value, int value2)
	{
		if(value > value2)
		{
			Console.WriteLine("Value 1 is larger than value 2");
		} 
		else
		{
			Console.WriteLine("Value 2 is larger than value 1");
		}
	}
	public void CheckPassword(string password)
	{
		if(password == "ouke23")
		{
			Console.WriteLine("Correct password");
		}
		else
		{
			Console.WriteLine("Incorrect password");
		}
	}
}