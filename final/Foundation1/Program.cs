using System;

class Program
{
    static void Main(string[] args)
    {
         // Creating videos
        List<Video> videos = new List<Video>
        {
            new Video("Video 1", "Author 1", 240),
            new Video("Video 2", "Author 2", 360),
            new Video("Video 3", "Author 3", 300)
        };

        // Adding comments to videos
        videos[0].AddComment("User1", "Superb video!");
        videos[0].AddComment("User2", "Very educational and informative");
        videos[0].AddComment("User3", "Could have been much better than this");

        videos[1].AddComment("User4", "I Loved it!");
        videos[1].AddComment("User5", "Great content");

        videos[2].AddComment("User6", "A Marvelous work!");
        videos[2].AddComment("User7", "Appreciate your sharing");

        // Displaying video information
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}