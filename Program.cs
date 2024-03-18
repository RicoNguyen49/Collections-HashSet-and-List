using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first HashSet object 
        HashSet<string> internationalSports = new HashSet<string>();
        internationalSports.Add("Soccer");
        internationalSports.Add("Curling");
        internationalSports.Add("Baseball");
        internationalSports.Add("Basketball");
        internationalSports.Add("Skiing");

        // Create the second HashSet object 
        HashSet<string> Sports = new HashSet<string>();
        Sports.Add("Football");
        Sports.Add("Basketball");
        Sports.Add("Skiing");
        Sports.Add("Rugby");
        Sports.Add("Baseball");

        // Create the third HashSet object 
        HashSet<string> AmericanSports = new HashSet<string>();
        AmericanSports.Add("Football"); 
        AmericanSports.Add("Basketball"); 
        AmericanSports.Add("hockey");
        AmericanSports.Add("Soccer");
        AmericanSports.Add("Baseball");

        // Combine the first and second HashSet objects
        Sports.UnionWith(internationalSports);

        // Print out the combined list
        Console.WriteLine("Combined Sports list:");
        foreach (string item in Sports)
        {
            Console.WriteLine(item);
        }

        // Create a new HashSet object to store duplicates
        HashSet<string> duplicatesHashSet = new HashSet<string>();

        // Find and store items that appear in both the first and third objects
        foreach (string item in internationalSports)
        {
            if (AmericanSports.Contains(item))
            {
                duplicatesHashSet.Add(item);
            }
        }

        // Print out the contents of the duplicates HashSet object
        Console.WriteLine("\nSports that is played in the US and internationally:");
        foreach (string item in duplicatesHashSet)
        {
            Console.WriteLine(item);
        }





        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("USING LIST");

        // Create a List
        List<string> games = new List<string> { };

        // Add games to the list
        games.Add("Valorant");
        games.Add("Fortnite");
        games.Add("COD");
        games.Add("GTA 5");
        games.Add("Fifa");

        // Use AddRange() method 
        string[] memberArr = new string[] { "Steep", "League of legends", "CSGO", "Minecraft" };
        games.AddRange(memberArr);

        // Sort the list and print all the games
        games.Sort();
        Console.WriteLine("Sorted List:");
        foreach (String item in games)
        {
            Console.WriteLine(item);
        }

        // Remove game
        games.RemoveAt(2); // Remove the game at index 2

        // Sort the list in reverse order and print all games
        games.Sort((a, b) => b.CompareTo(a)); // Sort in reverse order
        Console.WriteLine("\nSorted List in Reverse Order after 1 game was removed:");
        foreach (String item in games)
        {
            Console.WriteLine(item);
        }
    }
}
