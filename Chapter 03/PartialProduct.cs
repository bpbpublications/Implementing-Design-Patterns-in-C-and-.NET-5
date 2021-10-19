using System;

namespace _3.ChapterThree
{
    public partial class Product: IProduct
    {
        public Product()
        {

        }

        public Product (string title)
        {
            this.Title = title;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public void Deliver()
        {
            throw new NotImplementedException();
        }
    }
}
