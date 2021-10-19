using System;
using System.Collections.Generic;
using System.Text;

namespace _7.ChapterSeven
{
    public class TenGigabytes : IMobileDataFactory
    {
        public string Name { get; set; } = "10 Gb/sec";
        public string Limit { get; set; } = "10 Gb/sec";
    }
}
