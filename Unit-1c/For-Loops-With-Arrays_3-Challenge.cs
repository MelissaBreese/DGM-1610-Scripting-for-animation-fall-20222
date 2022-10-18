using System;

public class Program
{
    public void Main()
    {
        string[] heroes = {"Ironman", "Ironman", "Ironman" };
		
        for (var i = 0; i < heroes.Length ; i++) {
		heroes [i] = "Thor";
			}
		
        foreach(var hero in heroes) {
			Console.WriteLine(hero);
		}
    }
}


