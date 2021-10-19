using System;
using System.Collections.Generic;
using System.Text;

namespace _7.ChapterSeven
{
    public class ThousandTextMessage : ITextMessageFactory
    {
        public string Name { get; set; } = "A thousand text messages";
        public string QuantityPerMonth { get; set; } = "1000";
    }
}
