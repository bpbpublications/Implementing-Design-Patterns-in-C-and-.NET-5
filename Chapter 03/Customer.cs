using System;
using System.Collections.Generic;
using System.Text;

namespace _3.ChapterThree
{
    struct Customer
    {
        public Customer(int id, string fullName, DateTime birthDay)
        {
            this.FullName = fullName;
            this.BirthDay = birthDay;
            this.Id = id;
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
