using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal theJournal = new Journal();
        string userChoice = "";
        while (userChoice != "5")
        {
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                string prompt = "What is the best part of my day?";
                Console.WriteLine(prompt);

                Console.Write("> ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                theJournal.AddEntry(newEntry);
            }

            else if (userChoice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
        }
    }

}
