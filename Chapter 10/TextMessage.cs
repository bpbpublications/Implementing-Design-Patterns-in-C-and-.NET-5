using System;
using System.Collections.Generic;
using System.Text;

namespace _10.ChapterTen
{
    public class TextMessage : ITextMessage
    {
        public string Name { get; set; }
        public int QuantityPerMonth { get; set; }
    }
}
