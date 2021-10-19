using System;
using System.Collections.Generic;
using System.Text;

namespace _7.ChapterSeven
{
    public interface IMobilePlanFactory
    {
        ITextMessageFactory CreateTextMessage();

        IConnectionSpeedFactory CreateConnectionSpeed();

        IMobileDataFactory CreateMobileData();
    }
}
