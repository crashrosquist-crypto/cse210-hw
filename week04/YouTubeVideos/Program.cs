using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video(600, "How to beat Dark Souls", "BootyCrasher");
        v1.AddComment(new Comment("User1", "First!"));
        v1.AddComment(new Comment("Solaire", "Praise the sun!"));

        Video v2 = new Video(1000, "How to discipline your cat", "CatGuyIsCool");
        v2.AddComment(new Comment("CatLover82", "Now I can properly discipline my silly cat"));
        v2.AddComment(new Comment("DarkKnightCat", "I have a black cat and I make it look like Batman"));

        Video v3 = new Video(2000, "How to install Rain Gutters", "HomeImprovement-guy");
        v3.AddComment(new Comment("Handymanguy", "Wow I can install rain gutters now, cool!"));
        v3.AddComment(new Comment("rada", "blah blah"));
        v3.AddComment(new Comment("ricola", "yodelheehoo"));

        videos.Add(v2);
        // v2.DisplayInfo();

        videos.Add(v1);
        videos.Add(v3);
        // v1.DisplayInfo();

        Console.WriteLine("\n---YouTube Video Gallery ---\n");

        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine("---------------------------------------------\n");
        }
    }
}