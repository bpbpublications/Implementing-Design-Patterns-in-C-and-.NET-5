using System;

namespace _4.ChapterFour
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        public int Type { get; set; }

        decimal CalculateDiscount()
        {
            return 0.3m;
        }
    }

    public interface IPhysicalProduct
    {
        public int HeightDimension { get; set; }
        public int WidthDimension { get; set; }
    }

    public interface IOnlineProduct 
    { 
        int DownloadSize { get; set; }
    
    }
}
