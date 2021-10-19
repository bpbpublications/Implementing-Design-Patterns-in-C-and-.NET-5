using System;

namespace _14.ChapterFourteen
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}
