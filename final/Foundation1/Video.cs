using System;
using System.Collections.Generic;
using System.IO;
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string text)
    {
        Comments.Add(new Comment(commenterName, text));
    }

    public int GetNumComments()
    {
        return Comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Length (seconds): " + Length);
        Console.WriteLine("Number of comments: " + GetNumComments());
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Commenter: " + comment.CommenterName);
            Console.WriteLine("Text: " + comment.Text);
        }
    }
}