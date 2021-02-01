using Praticas2021_2.Entities;
using System;

namespace Praticas2021_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comments c1 = new Comments("Have a nice trip");
            Comments c2 = new Comments("Wooowww");
            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:00"), "Travaling a new zeeland", "I´m going to visit new zeeland", 12);
            p1.AddComments(c1);
            p1.AddComments(c2);


            Comments c3 = new Comments("Good night");
            Comments c4 = new Comments("May tge force be with you");

            Post p2 = new Post(DateTime.Now, "Comments test", "É so um teste", 100);
            p2.AddComments(c3);
            p2.AddComments(c4);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
