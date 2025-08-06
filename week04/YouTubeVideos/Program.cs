using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The 12-Month Software Developer Roadmap", "TechLead", 3600);
        video1.AddComment(new Comment("Alex", "This roadmap is super helpful."));
        video1.AddComment(new Comment("Camilo", "I'm on month 3 and I'm already building my first portfolio project. Thanks for the advice!"));
        video1.AddComment(new Comment("Alejandra", "Do you think this is still relevant for 2025?"));
        video1.AddComment(new Comment("Emily", "I've been trying to learn for years, this is the first video that actually made sense."));

        
        Video video2 = new Video("Python Crash Course for Beginners", "FreeCodeCamp.org", 5400);
        video2.AddComment(new Comment("David", "The instructor is amazing. I love how they explain complex topics simply."));
        video2.AddComment(new Comment("Carlos", "I used this video to prepare for an interview and it worked perfectly!"));
        video2.AddComment(new Comment("Paula", "This is the best free Python course on YouTube, hands down."));


        Video video3 = new Video("Soft Skills Every Developer Needs", "Traversy Media", 900);
        video3.AddComment(new Comment("Olivia", "Great reminder that it's not all about the code. Communication is key!"));
        video3.AddComment(new Comment("Ryan", "I wish I had watched this video earlier in my career."));
        video3.AddComment(new Comment("Marcela", "So true!"));

        
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"  - {comment._commenterName}: {comment._commentText}");
            }
            Console.WriteLine();
       }
    }
}