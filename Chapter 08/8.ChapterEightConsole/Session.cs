using System;
using System.Collections.Generic;
using System.Text;

namespace _8.ChapterEightConsole
{
    public class Session
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
