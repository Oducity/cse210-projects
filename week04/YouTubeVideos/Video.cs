public class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> _comments = new List<Comment>();


    public Video()
    {

    }

    public void GetComments()
    {
        int commentCount = 0;
        foreach (Comment com in _comments)
        {
            commentCount++;
            Console.WriteLine($"Name of Commenter: {com._nameOfCommenter}, Comment:{com._text}.");
            
        }
        Console.WriteLine("Number of comments: " + commentCount);
    }
    
}