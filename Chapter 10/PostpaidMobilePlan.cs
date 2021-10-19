using System;
using System.Collections.Generic;
using System.Text;

namespace _10.ChapterTen
{
    public class PostpaidMobilePlan : IMobilePlan
    {
        public IConnectionSpeed ConnectionSpeed { get; set; }
        public ITextMessage TextMessage { get; set; }

        public void PostPaidIntegration()
        {

        }
    }
}
