using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video("Big Tree","Henry",30);
        Comments.AddComment(video1, "Jose", "Great");
        Comments.AddComment(video1, "Mario", "Amazing");
        Comments.AddComment(video1, "Zene", "Nice");
                
        Video video2 = new Video("Super Jump","Mario",320);
        Comments.AddComment(video2, "Juaco", "Good Job");
        Comments.AddComment(video2, "Richard", "Great");
        Comments.AddComment(video2, "William", "Let Do It");
                
        Video video3 = new Video("Video Games","Jose",130);
        Comments.AddComment(video3, "Moquete", "Good Game");
        Comments.AddComment(video3, "Deivi", "Come ooooonnnnn!!!");
        Comments.AddComment(video3, "Johnson", "Nice Game.");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach(Video video in videos){
            
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Number of comments: " + video.NumberofComments());
            Console.WriteLine();
            foreach(Comments comment in video.comments){
                Console.WriteLine(comment._name + " -- " + comment._comment);
            }
            Console.WriteLine();

        }
    }
}