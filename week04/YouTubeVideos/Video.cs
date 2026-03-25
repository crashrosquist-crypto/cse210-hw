using System;

public class Video
{
    public int _videoLength;
    public string _title;
    public string _author;
    public List<Comment> _comments = new List<Comment>();

    public Video(int videoLength,string title, string author)
    {
        _videoLength = videoLength;
        _title = title;
        _author = author;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_videoLength}s");
        Console.WriteLine($"Number of Comments {GetCommentCount()}");

        foreach (var comment in _comments)
        {
            comment.DisplayComment();
        }
    }


}