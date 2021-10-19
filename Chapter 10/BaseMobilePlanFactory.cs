using System;
using System.Collections.Generic;
using System.Text;

namespace _10.ChapterTen
{
    public abstract class BaseMobilePlanFactory
    {
        public IMobilePlan GetMobilePlan()
        {
            IMobilePlan mobilePlan = this.CreateMobilePlan();

            return mobilePlan;
        }

        public abstract IMobilePlan CreateMobilePlan();
    }
}
