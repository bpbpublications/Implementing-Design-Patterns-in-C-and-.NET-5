using System;
using System.Collections.Generic;
using System.Text;

namespace _10.ChapterTen
{
    public interface IMobilePlan
    {
        IConnectionSpeed ConnectionSpeed { get; set; }
        ITextMessage TextMessage { get; set; }
    }
}
