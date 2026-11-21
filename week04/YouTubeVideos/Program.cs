using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        //video 1
        Video video1 = new Video("The Simplest Math Problem No Computer Can Solve", "Veritasium", 2328);

        //video 2
        Video video2 = new Video("Relativity is so much weirder than we thought...", "Veritasium", 2068);

        //video 3
        Video video3 = new Video("Fiber Optics are som much cooler than I thought", "Veritasium", 2072);

        //comment 1
        Comment comment1 = new Comment();
        comment1.CreateComment("pubfixture", "The BIGGEST exploit here is that Casinos have exploited lawmakers and lawmen, to criminalize people who legit find a way to beat their game.");
        video1.AddComment(comment1);
        
        //comment 2
        Comment comment2 = new Comment();
        comment2.CreateComment("KSwingy", "Each Veritasium video has a 50% chance of mentioning Los Alamos");
        video1.AddComment(comment2);
        
        //comment 3
        Comment comment3 = new Comment();
        comment3.CreateComment("hermaeusmora2945", "How dare people try and cheat the honest hard working casinos...");
        video1.AddComment(comment3);
        
        //comment 4
        Comment comment4 = new Comment();
        comment4.CreateComment("dgoddard", "Einstein... keeping scientists busy since 1915.");
        video2.AddComment(comment4);
        
        //comment 5
        Comment comment5 = new Comment();
        comment5.CreateComment("Gearslinger-i5g", "The clock built to prove Einstein wrong. Proves Einstein right");
        video2.AddComment(comment5);
        
        //comment 6
        Comment comment6 = new Comment();
        comment6.CreateComment("SingularisFox", "Cooling down atoms with lasers to a millionth of a degree above absolute zero, while simultaneously trapping the aforementioned floating atoms in one spot, all to measure time so accurately we may change the understanding of gravit is not something I was prepared to hear today. Science is freakin amazing. This is exactly why I'm not ashamed to be called a nerd. Actually quite proud of it.");
        video2.AddComment(comment6);
        
        //comment 7
        Comment comment7 = new Comment();
        comment7.CreateComment("FER2000-z3v", "It's funny how we get frustrated when our internet takes a few seconds to load, without realizing that behind that connection are scientists who spent years solving a problem many believed was impossible.");
        video3.AddComment(comment7);
        
        //comment 8
        Comment comment8 = new Comment();
        comment8.CreateComment("k.k.o.3989", "I would love to see a video about submarine cables and fiber amplifiers!!!! thx");
        video3.AddComment(comment8);
        
        //comment 9
        Comment comment9 = new Comment();
        comment9.CreateComment("alifepenneddown", "34:30 - Dude dropped a note about 0.20 per km like it was nothing reaching that, IMO Japanese team deserve to be known and talked about too");
        video3.AddComment(comment9);

        //video work
        Console.Clear();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        for (int i = 0; i < videos.Count(); i++)
        {
            string videoText = videos[i].GetVideoText();
            Console.WriteLine($"Video {i + 1}: {videoText}");
            Console.WriteLine();
        }
    }
}