using System;

public class Program
{
    public void Main()
    {
        string[] heroes = {"Ironman", "Ironman", "Ironman" };
        heroes[0] = "Thor";
		heroes[2] = "Thor";
        foreach(var hero in heroes) {
			Console.WriteLine(hero);
		}
    }
}
