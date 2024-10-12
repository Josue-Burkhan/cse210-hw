using System;
class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learn the basics for good Portuguese!", "Manylanguages", 1070);
        Video video2 = new Video("Advanced C# Programming", "TechGuru", 1280);
        Video video3 = new Video("How to install vs code in 2024", "DevWorld", 950);

        video1.AddComment(new Comment("Alice", "Great, very helpful!"));
        video1.AddComment(new Comment("Bob", "I learned a lot, thanks!"));
        video1.AddComment(new Comment("Stewie", "This is awesome! now I can learn Portuguese faster"));

        video2.AddComment(new Comment("Diana", "The advanced part was tricky, but well explained"));
        video2.AddComment(new Comment("Eva", "I love this channel!"));

        video3.AddComment(new Comment("Miguel", "Thanks for this guide"));
        video3.AddComment(new Comment("Grace", "You saved me!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}
