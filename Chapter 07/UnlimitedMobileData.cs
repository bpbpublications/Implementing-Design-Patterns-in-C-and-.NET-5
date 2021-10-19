using System;
using System.Collections.Generic;
using System.Text;

namespace _7.ChapterSeven
{
    public class UnlimitedMobileData : IMobileDataFactory
    {
        public string Name { get; set; } = "Unlimited";
        public string Limit { get; set; } = "Unlimited";
    }
}
