using System;
using System.Collections.Generic;
using System.Text;

namespace _15.ChapterFifteen
{
    public class SaoPauloStrategy : ICityStrategy
    {
        public void ApplyEmploymentRules()
        {
            Console.WriteLine("Must have permanent employees");
        }

        public decimal ApplyProfit(decimal price)
        {
            return price * 0.15m;
        }

        public decimal ApplyTax(decimal price)
        {
            return price * 0.10m;
        }
    }
}
