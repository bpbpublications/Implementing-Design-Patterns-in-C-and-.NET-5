using System;

namespace ChapterOne1._34
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayOfWeek = DateTime.Now.DayOfWeek;

            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Today is Monday");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Today is Thursday");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Today is Friday");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Today is Saturday");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Today is Sunday");
                    break;

            }
        }
    }
}
