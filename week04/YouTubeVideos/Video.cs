public class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> _comments = new List<Comment>();

    public Video()
    {

    }

    public int GetNumberOfComments()
    {
        return 0;
    }
}