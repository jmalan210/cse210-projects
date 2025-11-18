//Author: Jennifer Malan 

using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args) {


        List<Video> videos = new List<Video>();

    //VIDEO 1//

        Video vid1 = new Video();
        vid1._title = "C# Coding Basic";
        vid1._author = "Paul Martinez";
        vid1._lengthInSec = 1837;
        videos.Add(vid1);

        Comment vid1Comment1 = new Comment();
        vid1Comment1._userName = "John Ellis";
        vid1Comment1._text = "Great video! I learned a lot!";
        vid1._comments.Add(vid1Comment1);

        Comment vid1Comment2 = new Comment();
        vid1Comment2._userName = "Ellie Jane";
        vid1Comment2._text = "Thanks for this! It was exactly what I needed.";
        vid1._comments.Add(vid1Comment2);

        Comment vid1Comment3 = new Comment();
        vid1Comment3._userName = "Hannah Smith";
        vid1Comment3._text = "I wish you'd talked more about encapsulation.";
        vid1._comments.Add(vid1Comment3);

        //VIDEO 2//

        Video vid2 = new Video();
        vid2._title = "C# Coding Intermediate";
        vid2._author = "Anna Gibson";
        vid2._lengthInSec = 3675;
        videos.Add(vid2);

        Comment vid2Comment1 = new Comment();
        vid2Comment1._userName = "Natalie George";
        vid2Comment1._text = "This video was just what I needed!";
        vid2._comments.Add(vid2Comment1);

        Comment vid2Comment2 = new Comment();
        vid2Comment2._userName = "Andrew Banks";
        vid2Comment2._text = "Meh. I've seen better videos on coding with C#.";
        vid2._comments.Add(vid2Comment2);

        Comment vid2Comment3 = new Comment();
        vid2Comment3._userName = "Mia Landon";
        vid2Comment3._text = "I lost 45 pounds in 6 weeks.  Ask me how!";
        vid2._comments.Add(vid2Comment3);

        //VIDEO 3 // 

        Video vid3 = new Video();
        vid3._title = "C# Coding Advanced";
        vid3._author = "Emma Johnson";
        vid3._lengthInSec = 5423;
        videos.Add(vid3);

        Comment vid3Comment1 = new Comment();
        vid3Comment1._userName = "Ethan Grady";
        vid3Comment1._text = "Excellent video! Thank you!";
        vid3._comments.Add(vid3Comment1);

        Comment vid3Comment2 = new Comment();
        vid3Comment2._userName = "Logan Wyatt";
        vid3Comment2._text = "The clearest explanations I've seen in a while.  Great video!";
        vid3._comments.Add(vid3Comment2);

        Comment vid3Comment3 = new Comment();
        vid3Comment3._userName = "Jared Preston";
        vid3Comment3._text = "I'm subscribing to your channel right now!";
        vid3._comments.Add(vid3Comment3);


       

        foreach (Video video in videos)
        {
            Console.WriteLine(video.DisplayVideoInfoAndComments());
            Console.WriteLine("____________________________________\n");

        }

        
    }
    }
