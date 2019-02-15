using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Program
    {
        //Design a class called Post. This class models a StackOverflow post. It should have properties
        //for title, description and the date/time it was created. We should be able to up-vote or down-vote
        //a post. We should also be able to see the current vote value. In the main method, create a post,
        //up-vote and down-vote it a few times and then display the the current vote value.
        //In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
        //and down-voting. You should not give the ability to set the Vote property from the outside,
        //because otherwise, you may accidentally change the votes of a class to 0 or to a random
        //number. And this is how we create bugs in our programs. The class should always protect its
        //state and hide its implementation detail.

        //Educational tip:
        //The aim of this exercise is to help you understand that classes should
        //encapsulate data AND behaviour around that data. Many developers (even those with years of
        //experience) tend to create classes that are purely data containers, and other classes that are
        //purely behaviour (methods) providers. This is not object-oriented programming. This is
        //procedural programming. Such programs are very fragile. Making a change breaks many parts
        //of the code.

        static void Main(string[] args)
        {
            var post = new Post
            {
                Title = "HELLO WORLD",
                Description = "This is some awesome description added to this stack overflow post."
            };

            Console.WriteLine("Title: " + post.Title);
            Console.WriteLine("Description: " + post.Description);
            Console.WriteLine("Date/Time Creation: " + post.CreationDateTime);

            post.UpVote();//1
            post.UpVote();//2
            post.UpVote();//3
            post.UpVote();//4
            post.UpVote();//5
            post.DownVote();//4
            post.DownVote();//3
            post.DownVote();//2


            Console.WriteLine("Number of Votes: "+ post.Score);

        }
    }

    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDateTime { get; } = DateTime.UtcNow;
        public int UpVoteCount { get; private set; }
        public int DownVoteCount { get; private set; }
        public int Score => UpVoteCount + DownVoteCount;

        public void UpVote()
        {
            UpVoteCount++;
        }

        public void DownVote()
        {
            DownVoteCount--;
        }
    }
}
