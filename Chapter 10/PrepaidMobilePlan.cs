using System;
using System.Collections.Generic;
using System.Text;

namespace _10.ChapterTen
{
    public class PrepaidMobilePlan : IMobilePlan
    {
        public IConnectionSpeed ConnectionSpeed { get; set; }
        public ITextMessage TextMessage { get; set; }

        public void PrepaidIntegration()
        {

        }
    }
}
