using System;
using System.Collections.Generic;
using System.Text;

namespace _6.ChapterSix6._1.LiskovPrinciple
{
    class PremiumUser:BaseUser
    {
        public void AccessToUnlimitedTitles()
        {
            Console.WriteLine("Access to unlimited titles");
        }

        public void GiveAccessFamilyMembers()
        {
            Console.WriteLine("Access granted to family members");
        }
    }
}
