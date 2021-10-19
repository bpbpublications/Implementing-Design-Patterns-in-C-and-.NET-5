using System;
using System.Collections.Generic;
using System.Text;

namespace _7.ChapterSeven
{
    public class PostpaidFactory : IMobilePlanFactory
    {
        public IConnectionSpeedFactory CreateConnectionSpeed()
        {
            return new HighSpeed();
        }

        public IMobileDataFactory CreateMobileData()
        {
            return new UnlimitedMobileData();
        }

        public ITextMessageFactory CreateTextMessage()
        {
            return new UnlimitedTextMessage();
        }
    }
}
