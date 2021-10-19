using System;
using System.Collections.Generic;
using System.Text;

namespace _15.ChapterFifteen
{
    public interface ICityStrategy
    {
        decimal ApplyTax(decimal price);
        void ApplyEmploymentRules();
        decimal ApplyProfit(decimal price);
    }
}
