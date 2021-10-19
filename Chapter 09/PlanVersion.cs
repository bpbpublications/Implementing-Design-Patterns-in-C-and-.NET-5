using System;
using System.Collections.Generic;
using System.Text;

namespace _9.ChapterNine
{
    [Serializable]
    public class PlanVersion
    {
        public int Version { get; set; }

        public DateTime Creation { get; set; }
        public DateTime Expiration { get; set; }
    }
}
