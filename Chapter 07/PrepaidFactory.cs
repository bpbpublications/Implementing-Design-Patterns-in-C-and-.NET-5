using System;
using System.Collections.Generic;
using System.Text;

namespace _7.ChapterSeven
{
    public class PrepaidFactory : IMobilePlanFactory
    {
        public IConnectionSpeedFactory CreateConnectionSpeed()
        {
            return new LowSpeed();
        }

        public IMobileDataFactory CreateMobileData()
        {
            return new TenGigabytes();
        }

        public ITextMessageFactory CreateTextMessage()
        {
            return new ThousandTextMessage();
        }
    }
}
