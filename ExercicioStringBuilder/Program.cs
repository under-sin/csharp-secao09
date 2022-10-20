using System;
using ExercicioStringBuilder.Entities;

namespace ExercicioStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice bad trip");
            Comment c2 = new Comment("Wow that's awesome");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:55"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);


            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("Nice short");

            Post p2 = new Post(
                    DateTime.Parse("21/06/2018 13:05:55"),
                    "I liker night walker",
                    "I'm going to visit this wonderful country",
                    5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
