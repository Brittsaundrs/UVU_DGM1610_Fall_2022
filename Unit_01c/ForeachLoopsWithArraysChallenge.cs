using System;
					
public class Program
{
	public static void Main()
	{
		weapon[] weaponsObjs = {new weapon(), new weapon()};
		weaponsObjs[1].weaponName = "Dagger";
		
		for(var i = 0; i < weaponsObjs.Length; i++)
		{
			weaponsObjs[i].powerLevel = 0;
		}
		foreach(var item in weaponsObjs)
		{
			Console.WriteLine(item.weaponName);
			Console.WriteLine(item.powerLevel);
		}
	}
}
public class weapon
{
	public string weaponName = "Axe";
	public int powerLevel = 1;
}