using System;

namespace _3.ChapterThree
{
    public  partial class Product
    {
       
        public virtual void ApplyDiscount()
        {
            this.Price = Decimal.Multiply(this.Price, (7 / 100));
        }
    }
}
