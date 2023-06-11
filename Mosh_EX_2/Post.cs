using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Mosh_EX_2
{
    internal class Post
    {
        private string _title;
        private string _description;
        private DateTime _created;
        private int _vote;

        public Post(string title, string description, DateTime created)
        {
            _title = title;
            _description = description;
            _created = created;
            _vote = 0;
        }

        public void UpVote()
        {
            this._vote++;
        }

        public void DownVote()
        {
            this._vote--;
        }

        public void ShowVotes()
        {
            Console.WriteLine("Vote for the " + this._title + " is : " + this._vote);
        }

        public void ShowPost()
        {
            Console.WriteLine("Title :  " + this._title);
            Console.WriteLine("Description : " + this._description);
            Console.WriteLine("\t\t- on : " + this._created);
        }
    }
}
