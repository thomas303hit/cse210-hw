using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store videos
            List<Video> videos = new List<Video>();

            // Create video 1
            Video video1 = new Video("C# Basics for Beginners", "Thomas", 2100);
            video1.AddComment(new Comment("Mary", "Clear explanation, really helpful!"));
            video1.AddComment(new Comment("Lucas", "Loved the section on loops."));
            video1.AddComment(new Comment("Anna", "Can you cover more about classes?"));
            videos.Add(video1);

            // Create video 2
            Video video2 = new Video("Python Crash Course", "Thomas", 1800);
            video2.AddComment(new Comment("Peter", "Great for beginners!"));
            video2.AddComment(new Comment("Sophie", "Loved the practical examples."));
            video2.AddComment(new Comment("James", "Could you include more on lists?"));
            video2.AddComment(new Comment("Emily", "Very well explained!"));
            videos.Add(video2);

            // Create video 3
            Video video3 = new Video("Advanced JavaScript Techniques", "Thomas", 2700);
            video3.AddComment(new Comment("Rachel", "The async/await part was awesome."));
            video3.AddComment(new Comment("Tom", "Great for reviewing concepts."));
            video3.AddComment(new Comment("Lisa", "More on frameworks, please!"));
            videos.Add(video3);

            // Create video 4
            Video video4 = new Video("Java Debugging Tips", "Thomas", 1500);
            video4.AddComment(new Comment("David", "These tips saved my project!"));
            video4.AddComment(new Comment("Chloe", "Really useful for beginners."));
            video4.AddComment(new Comment("Ryan", "Great explanation of breakpoints."));
            videos.Add(video4);

            // Display information for each video
            foreach (Video video in videos)
            {
                Console.WriteLine("\nVideo Information:");
                Console.WriteLine($"Title: {video.GetTitle()}");
                Console.WriteLine($"Author: {video.GetAuthor()}");
                Console.WriteLine($"Length: {video.GetLengthSeconds()} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
                Console.WriteLine("Comments:");
                
                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"  - {comment.GetCommenterName()}: {comment.GetCommentText()}");
                }
            }
        }
    }
}