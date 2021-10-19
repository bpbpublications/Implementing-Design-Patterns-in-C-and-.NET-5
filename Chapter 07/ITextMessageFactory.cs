using System;
using System.Collections.Generic;
using System.Text;

namespace _7.ChapterSeven
{
    public interface ITextMessageFactory
    {
        string Name { get; set; }
        string QuantityPerMonth { get; set; }
    }
}
