using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> videos = new List<Video>();

        // Create videos
        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment("User 1", "Great video!");
        video1.AddComment("User 2", "Interesting content.");
        video1.AddComment("User 3", "I learned a lot.");

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.AddComment("User 1", "Nice job!");
        video2.AddComment("User 2", "Very informative.");
        video2.AddComment("User 3", "Thank you so much for this video.");

        Video video3 = new Video("Video 3", "Author 3", 150);
        video3.AddComment("User 1", "Well explained.");
        video3.AddComment("User 2", "I have a question.");
        video3.AddComment("User 3", "The best tutorial video ever.");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video information
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}