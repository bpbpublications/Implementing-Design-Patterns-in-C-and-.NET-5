using System;
using System.Collections.Generic;
using System.Text;

namespace _3.ChapterThree
{
    public interface IProduct
    {
        int Id { get; set; }
        void Deliver() { Console.WriteLine("Default implementation"); }
    }
}
