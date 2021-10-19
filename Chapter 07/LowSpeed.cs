using System;
using System.Collections.Generic;
using System.Text;

namespace _7.ChapterSeven
{
    public class LowSpeed: IConnectionSpeedFactory
    {
        public string Name { get; set; } = "Low Speed";

        public string Velocity { get; set; } = "50 Mb/Sec";
    }
}
