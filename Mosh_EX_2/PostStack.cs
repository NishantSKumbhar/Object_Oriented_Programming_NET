using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Mosh_EX_2
{
    internal class PostStack
    {
        private readonly List<Post> posts;

        public PostStack()
        {
            posts = new List<Post>();
        }

        public void AddPost(Post post)
        {
            posts.Add(post);
        }

        public void RemovePost(Post post)
        {
            posts.Remove(post);
        }

        public void ShowAllPosts()
        {
            foreach (var post in posts)
            {
                post.ShowPost();
            }
        }
    }
}
