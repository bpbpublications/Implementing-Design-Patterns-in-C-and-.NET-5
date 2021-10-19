using System;
using System.Collections.Generic;
using System.Text;

namespace _12.ChapterTwelve
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        string Category { get; set; }
        void GetProductDetails();
        decimal GetProductPrice();
    }
}
