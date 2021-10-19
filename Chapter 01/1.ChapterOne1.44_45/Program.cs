using System;

namespace _1.ChapterOne1._44_45
{
    class Program
    {
        static void Main(string[] args)
        {
            Product productOne = new Product(1, "Product 1", 100);

            Product productTwo = productOne with { Title = "Product 2" };
        }
    }

    public record Product
    {
        public int Id { get; }
        public string Title { get; set; }
        public double Price { get; }

        public Product(int id, string title, double price) => (Id, Title, Price) = (id, title, price);
    }
}
