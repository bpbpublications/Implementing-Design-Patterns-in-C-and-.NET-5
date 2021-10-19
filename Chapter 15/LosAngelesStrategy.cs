using System;
using System.Collections.Generic;
using System.Text;

namespace _15.ChapterFifteen
{
    public class LosAngelesStrategy : ICityStrategy
    {
        public void ApplyEmploymentRules()
        {
            Console.WriteLine("No permanent employees");
        }

        public decimal ApplyProfit(decimal price)
        {
            return price * 0.10m;
        }

        public decimal ApplyTax(decimal price)
        {
            return price * 0.20m;
        }
    }
}
