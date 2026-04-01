using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Thread.Sleep(5000); // This is in miliseconds 1000 means 1 second

        Console.WriteLine(5);
        Thread.Sleep(1000);
        Console.WriteLine(4);
        Thread.Sleep(1000);
        Console.WriteLine(3);
        Thread.Sleep(1000);
        Console.WriteLine(2);
        Thread.Sleep(1000);
        Console.WriteLine(1);
        Thread.Sleep(1000);
        Console.WriteLine("Done!");

        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine("Done... AGAIN!");
    }
}