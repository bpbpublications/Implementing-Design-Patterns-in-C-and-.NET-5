using System;

namespace _5.ChapterFivePolymorphism
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public decimal Price { get; set; }

        public virtual void ApplyDiscount()
        {
            if(this.Price > 100)
            {
                this.Price = this.Price * 0.9m;
            }
        }
    }
}
