using System;

// I added a Thread.Sleep(2500); continue element at the bottom of the while loop so that it doesn't break the code when a user puts it an invalid choice.
class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will try to help you relax.", 30);
                breathing.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity("ReflectingActivity", "This activity can help you reflect on the day or times in your life.", 30);
                reflecting.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on your life yo.", 30);
                listing.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(2500);
                continue;
            }

        }
    }
}