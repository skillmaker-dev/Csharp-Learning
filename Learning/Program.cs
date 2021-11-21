using System;
using System.IO;
using System.Collections.Generic;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            post.Title = "I get an error when i add this line";
            post.Description = "Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit. Etiam erat massa, " +
                "dictum non nulla ut, faucibus vulputate nisl." +
                " Vivamus tempor augue orci, at bibendum metus elementum ac.";


            post.UpVote();

            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();

            Console.WriteLine(post.Vote);

        }

        
    }


    
    
}
