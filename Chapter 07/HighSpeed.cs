using System;
using System.Collections.Generic;
using System.Text;

namespace _7.ChapterSeven
{
    public class HighSpeed : IConnectionSpeedFactory
    {
        public string Name { get; set; } = "High Speed";

        public string Velocity { get; set; } = "500 Mb/Sec";
    }
}
