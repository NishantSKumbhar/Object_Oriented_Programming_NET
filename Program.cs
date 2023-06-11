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
            Console.WriteLine("---------------------------------------------------------------");
            Post p1 = new Post("Time", "Time is master worker \nthat heals the wounds of temporary defeat,\nand rights the wrongs of the world!\nThere is nothing impossible with time..", DateTime.Now);
            p1.UpVote();
            p1.UpVote();
            p1.UpVote();
            p1.DownVote();
            p1.ShowVotes();
            p1.ShowPost();
            Console.WriteLine("---------------------------------------------------------------");
        }
    }
}
