using System;
using System.Collections.Generic;
using System.Text;

namespace _10.ChapterTen
{
    public interface ITextMessage
    {
        string Name { get; set; }
        int QuantityPerMonth { get; set; }
    }
}
