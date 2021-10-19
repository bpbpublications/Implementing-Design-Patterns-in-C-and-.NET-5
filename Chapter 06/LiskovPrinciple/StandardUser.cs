using System;
using System.Collections.Generic;
using System.Text;

namespace _6.ChapterSix6._1.LiskovPrinciple
{
    class StandardUser:BaseUser
    {
        public void AccessToLimitedTitles()
        {
            Console.WriteLine("Access to limited titles");
        }
    }
}
