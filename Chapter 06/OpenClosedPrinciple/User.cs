using System;
using System.Collections.Generic;
using System.Text;

namespace _6.ChapterSix6._1.OpenClosedPrinciple
{
    class User : IUser
    {
        public string FullName { get; set; }
        public bool Active { get; set; }
        public string Email { get; set; }

        public IPlatformAccount PlatformAccount { get; set; } = new PlatformAccount();
    }
}
