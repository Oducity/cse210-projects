using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");


        Comment comment1 = new Comment();
        Comment comment2 = new Comment();
        Comment comment3 = new Comment();

        comment1._nameOfCommenter = "Jos Henry.";
        comment1._text = "This is a wonderful video.";

        comment2._nameOfCommenter = "perry height.";
        comment2._text = "Keep up the good work.";

        comment3._nameOfCommenter = "Evans Henry.";
        comment3._text = "love your video.";

        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();

        video1._title = "The Transporter";
        video1._author = "Luc Benson, Robert Mark Ben";
        video1._length = 65;
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        video2._title = "The Heads of States";
        video2._author = "John Watson";
        video2._length = 72;
        video2._comments.Add(comment1);
        video2._comments.Add(comment2);
        video2._comments.Add(comment3);

        video3._title = "The Beauty of Faith";
        video3._author = "Gregory Moon";
        video3._length = 120;
        video3._comments.Add(comment1);
        video3._comments.Add(comment2);
        video3._comments.Add(comment3);

        YouTubeAccount account = new YouTubeAccount();
        account._accountName = "Engr Oducity";
        account._videos.Add(video1);
        account._videos.Add(video2);
        account._videos.Add(video3);
        

        foreach (Video v in account._videos)
        {
            Console.WriteLine($"YouTube Account: " + account._accountName);
            Console.WriteLine($"Title: {v._title}.  Video Author: {v._author}.  Video Length: {v._length} minutes.");
            video1.GetComments();   
        }


    }
}