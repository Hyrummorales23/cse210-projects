using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Exploring the Mountains", "John Smith", 300);
        Video video2 = new Video("Cooking 101: Pasta", "Jane Doe", 180);
        Video video3 = new Video("Tech Gadgets Unboxing", "Tech Guru", 240);

        // Add comments to videos
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Amazing scenery."));
        video1.AddComment(new Comment("Charlie", "I love hiking too!"));

        video2.AddComment(new Comment("Diana", "Thanks for the recipe!"));
        video2.AddComment(new Comment("Ethan", "Looks delicious."));
        video2.AddComment(new Comment("Fiona", "I will try this tonight."));

        video3.AddComment(new Comment("George", "Very informative."));
        video3.AddComment(new Comment("Hannah", "Can’t wait to get these gadgets."));
        video3.AddComment(new Comment("Ian", "Awesome review!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}