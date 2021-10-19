using System;
using System.Collections.Generic;
using System.Text;

namespace _4.ChapterFour
{
    public class WashingMachine : IProduct, IPhysicalProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int HeightDimension { get; set; }
        public int WidthDimension { get; set; }
        public int Type { get; set; }

        public decimal CalculateDiscount()
        {
            return 0.3m;
        }
    }
}
