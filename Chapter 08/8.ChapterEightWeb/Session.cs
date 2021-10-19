using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8.ChapterEightWeb
{
    public class Session
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
