using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");


        Comment comment1 = new Comment();
        Comment comment2 = new Comment();
        Comment comment3 = new Comment();

        comment1._nameOfCommenter = "Jos Henry.";
        comment1._text = "This is a wonderful video.";

        comment2._nameOfCommenter = "perry height.";
        comment2._text = "Keep up the good work.";

        comment3._nameOfCommenter = "Oducity Henry.";
        comment3._text = "love your video.";

        //Video video1 = new Video();
        //Video video2 = new Video();
        //Video video3 = new Video();

    }
}