using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List of scriptures from the New Testament and Book of Mormon
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, " +
                "that whosoever believeth in him should not perish, but have everlasting life."),

            new Scripture(new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy."),

            new Scripture(new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."),

            new Scripture(new Reference("Mosiah", 18, 9),
                "Stand as witnesses of God at all times and in all things, " +
                "and in all places that ye may be in, even until death.")
        };

        Random rand = new Random();
        Scripture chosenScripture = scriptures[rand.Next(scriptures.Count)];

        Console.Clear();
        Console.WriteLine("Memorize the scripture below:\n");
        Console.WriteLine(chosenScripture.GetDisplayText());
        Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit.");

        string input = "";
        while (input.ToLower() != "quit" && !chosenScripture.IsCompletelyHidden())
        {
            input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            chosenScripture.HideRandomWords(3); // hide 3 words at a time
            Console.Clear();
            Console.WriteLine(chosenScripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to continue or type 'quit' to exit.");
        }

        Console.WriteLine("\n--- Program ended ---");
    }
}
