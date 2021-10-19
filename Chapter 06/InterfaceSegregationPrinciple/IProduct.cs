using System;
using System.Collections.Generic;
using System.Text;

namespace _6.ChapterSix6._1.InterfaceSegregationPrinciple
{
    interface IProduct
    {
        public string ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
    }
}
