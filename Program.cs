using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Console_OOP.Exercise;
using Console_OOP.Sample_Mobile;
using Console_OOP.Mosh_EX_1;
using Console_OOP.Composition;
using Console_OOP.Mosh_EX_2;


namespace Console_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Post p1 = new Post("Time", "Time is master worker \nthat heals the wounds of temporary defeat,\nand rights the wrongs of the world!\nThere is nothing impossible with time..", DateTime.Now);
            p1.UpVote();
            p1.UpVote();
            p1.UpVote();
            p1.DownVote();
            //p1.ShowVotes();
            //p1.ShowPost();

            Post p2 = new Post("Opportunity", "We need not seek opportunity in distance;\nthat we may find it right where we stand.", DateTime.Now);
            
            p2.UpVote();
            p2.UpVote();
            p2.DownVote();
            //p2.ShowVotes();
            //p2.ShowPost();

            PostStack PStack = new PostStack();
            PStack.AddPost(p1);
            PStack.AddPost(p2);

            PStack.ShowAllPosts();
        }
    }
}
