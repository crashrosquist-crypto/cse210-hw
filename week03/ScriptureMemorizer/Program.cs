using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        

        Reference myRef = new Reference("Proverbs", 3, 5, 6);
        Scripture myScripture = new Scripture(myRef, "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        string input = "";

        while (input.ToLower() != "quit" && !myScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(myScripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                myScripture.HideRandomWords(3);
            }
        }
        
        Console.Clear();
        Console.WriteLine(myScripture.GetDisplayText());
    }
}