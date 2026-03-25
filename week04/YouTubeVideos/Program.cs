using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();

        Video v1 = new Video(600, "How to beat Dark Souls", "BootyCrasher");
        v1.AddComment(new Comment("User1","First!"));
        v1.AddComment(new Comment("Solaire", "Praise the sun!"));

        Video v2 = new Video(1000, "How to discipline your cat", "CatGuyIsCool");
        v2.AddComment(new Comment("CatLover82", "Now I can properly discipline my silly cat"));
        v2.AddComment(new Comment("DarkKnightCat","I have a black cat and I make it look like Batman"));

        videos.Add(v2);
        // v2.DisplayInfo();

        videos.Add(v1);
        // v1.DisplayInfo();

        Console.WriteLine("\n---YouTube Video Gallery ---\n");

        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine("---------------------------------------------\n");
        }
    }
}