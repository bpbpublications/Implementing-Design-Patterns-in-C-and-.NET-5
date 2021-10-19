using System;

namespace ChapterOne1._33
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayOfWeek = DateTime.Now.DayOfWeek;

            if(dayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("Today is Saturday");
            }
            else
            {
                Console.WriteLine("Today is not Saturday");
            }

            if (DateTime.Now.Day == 1)
                Console.WriteLine("Today is the first day of the month");
        }

        
    }
}
