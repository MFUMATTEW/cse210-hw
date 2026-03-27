public class Comment
{
    public string _commentAuthor;
    public string _commentText;

    public void Display()
    {
        Console.WriteLine($"{_commentAuthor}: {_commentText}");
    }

}