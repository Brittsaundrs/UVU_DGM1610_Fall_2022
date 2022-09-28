using System;
					
public class Program
{
	int year = 2;
	public void AskYear()
	{
		int year = 2;
		switch (year)
		{
			case 1:
				Console.WriteLine("Freshman");
				break;
			case 2:
				Console.WriteLine("Sophomore");
				break;
			case 3:
				Console.WriteLine("Junior");
				break;
			case 4:
				Console.WriteLine("Senior");
				break;
		}
	}
	public void PickPerson(string person)
	{
		if(person == "Britt")
		{
			Console.WriteLine(year.case2);
		}
	}
	public void Main()
	{
		
	}
}
/* I got a little confused. Here's the pseudocode:
if person == Britt
    ask what year this person is in
    if input == 2
        print("Your name is Britt and you are a Sophomore") */