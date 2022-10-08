using System;

public class Program
{
    public void Main()
    {
        string[] powers = {"Flight", "Creation", "Zero Gravity", "Ice", "Fire"};
        Console.WriteLine(powers.Length);
        foreach(var power in powers) {
			Console.WriteLine(power);
		}
    }
}