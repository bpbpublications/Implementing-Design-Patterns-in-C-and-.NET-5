using System;
using System.Collections.Generic;
using System.Text;

namespace _7.ChapterSeven
{
    public class UnlimitedTextMessage : ITextMessageFactory
    {
        public string Name { get; set; } = "Unlimited Text Message";
        public string QuantityPerMonth { get; set; } = "Unlimited";
    }
}
