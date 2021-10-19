using System;
using System.Collections.Generic;
using System.Text;

namespace _16.ChapteSixteen
{
    public class User : IObserver
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public void Update(object obj)
        {
            var post = (Post)obj;

            Console.WriteLine($"User: {this.FullName} - New Post: {post.Title} ");
        }
    }
}
