using System;
using System.Collections.Generic;
using System.Text;

namespace _3.ChapterThree
{
    public class Movie: Product
    {
        public DateTime ReleaseDate { get; set; }
        public string Category { get; set; }
        public int Duration { get; set; }

        public override void ApplyDiscount()
        {
            this.Price = Decimal.Multiply(this.Price, (10 / 100));
        }
    }
}
