using System;

namespace _5.ChapterFive
{
    public class Product
    {
        private decimal _discount;
        private decimal _price;
        public Product(decimal discount, decimal price)
        {
            this._discount = discount;
            this._price = price;
        }
        public int Id { get; set; }
        public string Name
        {
            get { return Name.ToUpper(); }
            set { this.Name = value; }
        }
        public int Type { get; set; }
        public decimal Price
        {
            get { return _price; }
            set { this._price = CheckPrice(Price); }
        }
        public decimal Discount
        {
            get { return _discount; }
            set { this._discount = CheckPrice(Discount); }
        }

        private static decimal CheckDiscount(decimal discount)
        {
            if(discount < 0 || discount > 10)
            {
                throw new ArgumentOutOfRangeException();
            }

            return discount;
        }

        private static decimal CheckPrice(decimal price)
        {
            if(price < 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            return price;
        }
    }
}
