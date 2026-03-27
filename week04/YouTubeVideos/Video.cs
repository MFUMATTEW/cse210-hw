using System.ComponentModel.DataAnnotations;

public class Video
{
    public string _author;
    public string _title;
    public int _length;

    public List<Comment> _commentTracked = new List<Comment>();

    public void AddComment(Comment newComment)
    {
        _commentTracked.Add(newComment);
    }

    public void DisplayAll()
    {
        Console.WriteLine($"Tiltle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {_commentTracked.Count}");


        foreach (Comment comment in _commentTracked)
        {
            comment.Display();
        }
    }


    
}