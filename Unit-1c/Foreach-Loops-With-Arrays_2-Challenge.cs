using System;

public class Program
{
    public void Main()
    {
        string[] artists = {"Kane Brown", "Luke Combs", "Carrie Underwood","Eric Church", "Luke Brian", "Toby Keith","Kelly Clarkson"};
		Console.WriteLine(artists.Length);
		foreach(var artist in artists)  {
		Console.WriteLine(artist);
		}
    }
}