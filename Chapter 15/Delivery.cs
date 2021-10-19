using System;
using System.Collections.Generic;
using System.Text;

namespace _15.ChapterFifteen
{
    public class Delivery
    {
        ICityStrategy _cityStrategy;
        public Delivery(ICityStrategy cityStrategy)
        {
            _cityStrategy = cityStrategy;
        }
        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Tax => _cityStrategy.ApplyTax(this.Price);
        public decimal Profit => _cityStrategy.ApplyProfit(this.Price);
        public decimal Price { get; set; }

    }
}
