using System;
using System.Collections.Generic;
using System.Text;

namespace _3.ChapterThree
{
    public static class Helper
    {
        public static string GetUniqueIdentifier()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
